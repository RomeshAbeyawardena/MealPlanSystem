using MealPlanSystem.Enumerations;
using MediatR;

namespace MealPlanSystem.Features.MealPlanEntry;

public record Query : IRequest<IQueryable<PlanEntry>>, IQuery
{
    public Guid? Id { get; set; }
    public Guid? PlanEntryTypeId { get; set; }
    public PlanEntryType? PlanEntryType { get; set; }
    public string? NameSearch { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public bool? NoTracking { get; set; }
    public bool ProcessDateRange { get; set; }
}
