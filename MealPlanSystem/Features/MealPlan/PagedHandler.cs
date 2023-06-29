using AutoMapper;
using MediatR;
using RST.Contracts;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;
using System.Linq.Expressions;

namespace MealPlanSystem.Features.MealPlan;

public class PagedHandler : PagedRepositoryHandlerBase<PagedQuery, Plan>
{
    [Inject] protected IMapper? Mapper { get; set; }
    [Inject] protected IMediator? Mediator { get; set; }

    public PagedHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    protected override Expression<Func<Plan, bool>> DefineDateRangeQuery(IDateRangeQuery query)
    {
        return QueryHandler.DateExpression(query);
    }

    public override async Task<IPagedResult<Plan>> Handle(PagedQuery request, CancellationToken cancellationToken)
    {
        var query = await Mediator!.Send(Mapper!.Map<Query>(request), cancellationToken);
        return await ProcessPagedQuery(query, request, cancellationToken);
    }
}
