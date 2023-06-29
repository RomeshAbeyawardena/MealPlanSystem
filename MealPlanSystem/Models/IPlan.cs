namespace MealPlanSystem.Models;

public interface IPlan
{
    Guid? Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }
    bool IsEnabled { get; set; }
    DateTimeOffset? StartDate { get; set; }
    DateTimeOffset? EndDate { get; set; }
}
