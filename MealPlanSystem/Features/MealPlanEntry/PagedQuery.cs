using MealPlanSystem.Enumerations;
using MediatR;
using RST.Contracts;
using RST.Enumerations;

namespace MealPlanSystem.Features.MealPlanEntry;

public record PagedQuery : IPagedRequest<PlanEntry>, IQuery
{
    public Guid? PlanEntryTypeId { get; set; }
    public PlanEntryType? PlanEntryType { get; set; }
    public string? NameSearch { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public bool? NoTracking { get; set; }
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public Guid? Id { get; set; }
}
