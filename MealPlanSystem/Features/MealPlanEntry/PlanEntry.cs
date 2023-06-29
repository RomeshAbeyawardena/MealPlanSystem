using MealPlanSystem.Features.MealPlan;
using MealPlanSystem.Features.MealPlanEntryType;
using MealPlanSystem.Models;
using RST.Attributes;
using RST.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanSystem.Features.MealPlanEntry;

[Table(nameof(PlanEntry))]
public record PlanEntry : IPlanEntry, IIdentity
{
    [Key]
    public Guid? Id { get; set; }
    public Guid? PlanId { get; set; }
    public Guid PlanEntryTypeId { get; set; }
    public Guid UnitTypeId { get; set; }
    [Required, ColumnDescriptor(System.Data.SqlDbType.NVarChar, 200)]
    public string? Name { get; set; }
    [ColumnDescriptor(System.Data.SqlDbType.NVarChar, 2000)]
    public string? Notes { get; set; }
    [ColumnDescriptor(System.Data.SqlDbType.Decimal, 38, 5)]
    public decimal? Amount { get; set; }
    [ColumnDescriptor(System.Data.SqlDbType.Decimal, 38, 5)]
    public decimal? Cost { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public DateTimeOffset Created { get; set; }
    
    public virtual Plan? Plan { get; set; }
    public virtual PlanEntryType? PlanEntryType { get; set; }
    
    Guid IIdentity<Guid>.Id { get => Id.GetValueOrDefault(); set => Id = value; }
}
