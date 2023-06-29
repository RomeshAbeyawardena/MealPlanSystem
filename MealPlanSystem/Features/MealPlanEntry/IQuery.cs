using MealPlanSystem.Enumerations;
using RST.Contracts;

namespace MealPlanSystem.Features.MealPlanEntry;

public interface IQuery : IDateRangeQuery
{
    Guid? Id { get; set; }
    Guid? PlanEntryTypeId { get; set; }
    PlanEntryType? PlanEntryType { get; set; }
    string? NameSearch { get; set; }
}
