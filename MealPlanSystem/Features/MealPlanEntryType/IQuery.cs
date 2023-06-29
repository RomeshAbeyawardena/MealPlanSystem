using RST.Contracts;

namespace MealPlanSystem.Features.MealPlanEntryType;

public interface IQuery : IDbQuery
{
    Guid? Id { get; set; }
    string? NameSearch { get; set; }
}
