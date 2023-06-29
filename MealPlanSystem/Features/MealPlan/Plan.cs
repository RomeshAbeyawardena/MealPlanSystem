using MealPlanSystem.Models;
using RST.Attributes;
using RST.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanSystem.Features.MealPlan;

[Table(nameof(Plan))]
public record Plan : IPlan, IIdentity
{
    Guid IIdentity<Guid>.Id { get => Id.GetValueOrDefault(); set => Id = value; }

    [Key]
    public Guid? Id { get; set; }
    [ColumnDescriptor(System.Data.SqlDbType.NVarChar, 200),
     Required]
    public string? Name { get; set; }
    [ColumnDescriptor(System.Data.SqlDbType.NVarChar, 2000)]
    public string? Description { get; set; }
    public bool IsEnabled { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
}
