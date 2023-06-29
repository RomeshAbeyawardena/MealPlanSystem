using AutoMapper;
using MediatR;
using RST.Contracts;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace MealPlanSystem.Features.MealPlanEntry;

public class PagedHandler : PagedRepositoryHandlerBase<PagedQuery, PlanEntry>
{
    [Inject] IMapper? Mapper { get; set; }
    [Inject] IMediator? Mediator { get; set; }
    public PagedHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override async Task<IPagedResult<PlanEntry>> Handle(PagedQuery request, CancellationToken cancellationToken)
    {
        var query = await Mediator!.Send(Mapper!.Map<Query>(request), cancellationToken);

        return await ProcessPagedQuery(query, request, cancellationToken);
    }
}
