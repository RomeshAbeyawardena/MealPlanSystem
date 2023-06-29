using AutoMapper;
using MealPlanSystem.Features.MealPlanEntryType;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RST.Contracts;
using RST.DependencyInjection.Extensions.Attributes;

namespace MealPlanSystem.Api.Features.MealPlanEntryType;

[ApiController, Route(API_URL)]
public class Controller : RST.DependencyInjection.Extensions.EnableInjectionBase<InjectAttribute>
{
    [Inject] protected IMapper? Mapper { get; set; }
    [Inject] protected IMediator? Mediator { get; set; }
    public const string API_URL = $"{Api.BASE_API_URL}/MealPlanEntryType";

    public Controller(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        base.ConfigureInjection();
    }

    [HttpGet, Route("{id?}")]
    public async Task<IPagedResult<PlanEntryType>> GetPlanEntryTypes([FromQuery]PagedQuery query, CancellationToken cancellationToken, Guid? id = null)
    {
        if(id.HasValue)
        {
            query.Id = id;
        }

        return Mapper!.Map<IPagedResult<PlanEntryType>>(
            await Mediator!.Send(query, cancellationToken));
    }

    [HttpPost]
    public async Task<PlanEntryType> SaveEntryType([FromForm]SaveCommand command, CancellationToken cancellationToken)
    {
        return Mapper!.Map<PlanEntryType>(
            await Mediator!.Send(command, cancellationToken));
    }

    [HttpPut, Route("{id?}")]
    public Task<PlanEntryType> SaveEntryType([FromForm] SaveCommand command, CancellationToken cancellationToken, Guid? id)
    {
        if (id.HasValue)
        {
            command.Id = id;
        }

        return SaveEntryType(command, cancellationToken);
    }
}
