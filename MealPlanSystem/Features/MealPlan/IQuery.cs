using RST.Contracts;

namespace MealPlanSystem.Features.MealPlan;

public interface IQuery : IDateRangeQuery
{
    Guid? Id { get; set; }
    string? NameSearch { get; set; }
}
