using AutoMapper;
using MealPlanSystem.Features.MealPlan;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RST.Contracts;
using RST.DependencyInjection.Extensions.Attributes;

namespace MealPlanSystem.Api.Features.MealPlan;

[ApiController, Route(API_URL)]
public class Controller : RST.DependencyInjection.Extensions.EnableInjectionBase<InjectAttribute>
{
    public const string API_URL = $"{Api.BASE_API_URL}/MealPlan";

    [Inject]
    protected IMediator? Mediator { get; set; }
    [Inject]
    protected IMapper? Mapper { get; set; }

    public Controller(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        base.ConfigureInjection();
    }

    [HttpGet, Route("{id?}")]
    public async Task<IPagedResult<Plan>> GetPlans([FromQuery]PagedQuery query, 
        CancellationToken cancellationToken, [FromRoute]Guid? id = null)
    {
        query.Id = id;
        return Mapper!.Map<IPagedResult<Plan>>(
            await Mediator!.Send(query, cancellationToken));
    }

    [HttpPost]
    public async Task<Plan> SavePlan([FromForm]SaveCommand command, 
        CancellationToken cancellationToken)
    {
        return Mapper!.Map<Plan>(
            await Mediator!.Send(command, cancellationToken));
    }

    [HttpPut, Route("{id}")]
    public Task<Plan> SavePlan([FromForm] SaveCommand command, CancellationToken cancellationToken, [FromRoute] Guid? id = null)
    {
        command.Id = id;
        return SavePlan(command, cancellationToken);
    }
}
