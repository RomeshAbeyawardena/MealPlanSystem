using AutoMapper;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace MealPlanSystem.Features.MealPlanEntryType;

public class PagedQueryHandler : PagedRepositoryHandlerBase<PagedQuery, PlanEntryType>
{
    protected IMapper? Mapper { get; set; }
    protected IMediator? Mediator { get; set; }
    public PagedQueryHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override async Task<IPagedResult<PlanEntryType>> Handle(PagedQuery request, CancellationToken cancellationToken)
    {
        var query = await Mediator!.Send(
            Mapper!.Map<Query>(request), cancellationToken);

        return await ProcessPagedQuery(query, request, cancellationToken);
    }
}
