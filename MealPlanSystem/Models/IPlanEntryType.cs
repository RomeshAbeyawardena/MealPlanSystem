namespace MealPlanSystem.Models;

public interface IPlanEntryType
{
    Guid? Id { get; set; }
    string? Name { get; set; }
    string? DisplayName { get; set; }
}
