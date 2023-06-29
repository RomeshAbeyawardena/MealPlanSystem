using RST.Contracts;
using RST.Enumerations;

namespace MealPlanSystem.Features.MealPlanEntryType;

public record PagedQuery : IPagedRequest<PlanEntryType>, IQuery
{
    public Guid? Id { get; set; }
    public string? NameSearch { get; set; }
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
