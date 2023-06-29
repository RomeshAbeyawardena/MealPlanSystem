using MealPlanSystem.Models;
using RST.Attributes;
using RST.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanSystem.Features.MealPlanEntryType;

[Table(nameof(PlanEntryType))]
public record PlanEntryType : IPlanEntryType, IIdentity
{
    Guid IIdentity<Guid>.Id { get => Id.GetValueOrDefault(); set => Id = value; }
    [Key]
    public Guid? Id { get; set; }
    [Required, ColumnDescriptor(System.Data.SqlDbType.NVarChar, 200)]
    public string? Name { get; set; }
    [ColumnDescriptor(System.Data.SqlDbType.NVarChar, 2000)]
    public string? DisplayName { get; set; }
}
