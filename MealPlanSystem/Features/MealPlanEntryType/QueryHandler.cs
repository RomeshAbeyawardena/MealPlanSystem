using Microsoft.EntityFrameworkCore;
using RST.Contracts;
using RST.Mediatr.Extensions;
using System.Linq.Expressions;

namespace MealPlanSystem.Features.MealPlanEntryType;

public class QueryHandler : RepositoryHandlerBase<Query, IQueryable<PlanEntryType>, PlanEntryType>
{
    public QueryHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public async override Task<IQueryable<PlanEntryType>> Handle(Query request, CancellationToken cancellationToken)
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

        return query;
    }
}
