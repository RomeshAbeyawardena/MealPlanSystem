using MealPlanSystem.Models;
using MediatR;
using RST.Contracts;

namespace MealPlanSystem.Features.MealPlanEntryType;

public record SaveCommand : IRequest<PlanEntryType>, IPlanEntryType, IDbCommand
{
    public bool CommitChanges { get; set; }
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
}
