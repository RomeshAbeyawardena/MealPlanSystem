using MealPlanSystem.Models;
using MediatR;
using RST.Contracts;

namespace MealPlanSystem.Features.MealPlanEntry;

public record SaveCommand : IRequest<PlanEntry>, IPlanEntry, IDbCommand
{
    public Guid? Id { get; set; }
    public Guid? PlanId { get; set; }
    public Guid PlanEntryTypeId { get; set; }
    public Guid UnitTypeId { get; set; }
    public string? Name { get; set; }
    public string? Notes { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Cost { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
