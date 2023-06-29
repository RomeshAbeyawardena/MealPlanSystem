using MealPlanSystem.Features.MealPlan;
using MealPlanSystem.Features.MealPlanEntry;
using MealPlanSystem.Features.MealPlanEntryType;
using Microsoft.EntityFrameworkCore;

namespace MealPlanSystem;

public class MealPlanDbContext : DbContext
{
    public MealPlanDbContext(DbContextOptions<MealPlanDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<Plan> Plans { get; set; }
    public DbSet<PlanEntry> PlanEntries { get; set; }
    public DbSet<PlanEntryType> PlanEntryTypes { get; set; }
}
