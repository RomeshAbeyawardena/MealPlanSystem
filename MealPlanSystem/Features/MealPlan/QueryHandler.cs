using Microsoft.EntityFrameworkCore;
using RST.Contracts;
using RST.Mediatr.Extensions;
using System.Linq.Expressions;

namespace MealPlanSystem.Features.MealPlan;

public class QueryHandler : RepositoryHandlerBase<Query, IQueryable<Plan>, Plan>
{
    public static Expression<Func<Plan, bool>> DateExpression(IDateRangeQuery query) => q => !query.StartDate.HasValue || !q.StartDate.HasValue || q.StartDate >= query.StartDate && (!query.EndDate.HasValue || !q.EndDate.HasValue) || q.EndDate <= query.EndDate;

    public QueryHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
    protected override Expression<Func<Plan, bool>> DefineDateRangeQuery(IDateRangeQuery query)
    {
        return DateExpression(query);
    }
    public override async Task<IQueryable<Plan>> Handle(Query request, CancellationToken cancellationToken)
    {
        Repository!.ResetQueryBuilder();
        request.ConfigureNoTracking(Repository);
        await Task.CompletedTask;
        var queryBuilder = Repository!.QueryBuilder;

        if (request.Id.HasValue)
        {
            queryBuilder.And(p => p.Id == request.Id);
        }

        if (!string.IsNullOrWhiteSpace(request.NameSearch))
        {
            queryBuilder.And(p => EF.Functions.Like(p.Name!, $"%{request.NameSearch}%"));
        }

        var query = Repository.Where(queryBuilder);

        IDateRangeQuery dateRangeQuery = request;
        if (request.ProcessDateRange && dateRangeQuery != null)
        {
            query = dateRangeQuery.FilterByDateRange(query, new Func<IDateRangeQuery, Expression<Func<Plan, bool>>>(DefineDateRangeQuery));
        }

        return query;
    }
}
