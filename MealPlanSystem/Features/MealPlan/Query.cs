using MediatR;

namespace MealPlanSystem.Features.MealPlan;

public record Query : IRequest<IQueryable<Plan>>, IQuery
{
    public Guid? Id { get; set; }
    public string? NameSearch { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public bool? NoTracking { get; set; }
    public bool ProcessDateRange { get; set; }
}
