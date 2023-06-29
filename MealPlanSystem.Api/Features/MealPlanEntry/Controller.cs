using AutoMapper;
using MealPlanSystem.Features.MealPlanEntry;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RST.Contracts;
using RST.DependencyInjection.Extensions;
using RST.DependencyInjection.Extensions.Attributes;

namespace MealPlanSystem.Api.Features.MealPlanEntry;

[ApiController, Route(API_URL)]
public class Controller : EnableInjectionBase<InjectAttribute>
{
    public const string API_URL = $"{Api.BASE_API_URL}/MealPlanEntry";

    [Inject] protected IMapper? Mapper { get; set; }
    [Inject] protected IMediator? Mediator { get; set; }

    public Controller(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        ConfigureInjection();
    }

    [HttpGet, Route("{id?}")]
    public async Task<IPagedResult<PlanEntry>> GetPlanEntryTypes([FromQuery] PagedQuery query, CancellationToken cancellationToken, Guid? id = null)
    {
        if (id.HasValue)
        {
            query.Id = id;
        }

        return Mapper!.Map<IPagedResult<PlanEntry>>(
            await Mediator!.Send(query, cancellationToken));
    }

    [HttpPost]
    public async Task<PlanEntry> SaveEntryType([FromForm] SaveCommand command, CancellationToken cancellationToken)
    {
        return Mapper!.Map<PlanEntry>(
            await Mediator!.Send(command, cancellationToken));
    }

    [HttpPut, Route("{id?}")]
    public Task<PlanEntry> SaveEntryType([FromForm] SaveCommand command, CancellationToken cancellationToken, Guid? id)
    {
        if (id.HasValue)
        {
            command.Id = id;
        }

        return SaveEntryType(command, cancellationToken);
    }
}
