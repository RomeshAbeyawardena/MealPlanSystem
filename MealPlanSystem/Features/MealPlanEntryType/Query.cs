using MediatR;

namespace MealPlanSystem.Features.MealPlanEntryType;

public record Query : IRequest<IQueryable<PlanEntryType>>, IQuery
{
    public Guid? Id { get; set; }
    public string? NameSearch { get; set; }
    public bool? NoTracking { get; set; }
}
