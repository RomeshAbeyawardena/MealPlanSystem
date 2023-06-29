using MealPlanSystem.Models;
using MediatR;
using RST.Contracts;

namespace MealPlanSystem.Features.MealPlan;

public record SaveCommand : IRequest<Plan>, IPlan, IDbCommand
{
    public Guid? Id { get; set; }
    public bool CommitChanges { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsEnabled { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
}
