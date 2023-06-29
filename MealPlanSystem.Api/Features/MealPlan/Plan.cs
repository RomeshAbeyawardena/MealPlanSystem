using MealPlanSystem.Models;

namespace MealPlanSystem.Api.Features.MealPlan;

public record Plan : IPlan
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsEnabled { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
}
