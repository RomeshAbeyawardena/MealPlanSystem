using RST.Contracts;

namespace MealPlanSystem.Models;

public interface IPlanEntry : ICreated
{
    Guid? Id { get; set; }
    Guid PlanEntryTypeId { get; set; }
    Guid UnitTypeId { get; set; }
    string? Name { get; set; }
    string? Notes { get; set; }
    decimal? Amount { get; set; }
    decimal? Cost { get; set; }
    DateTimeOffset? StartDate { get; set; }
    DateTimeOffset? EndDate { get; set; }
}
