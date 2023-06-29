using MealPlanSystem.Models;

namespace MealPlanSystem.Api.Features.MealPlanEntryType;

public record PlanEntryType : IPlanEntryType
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
}
