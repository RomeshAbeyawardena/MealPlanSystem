using LinqKit;
using RST;
using RST.EntityFrameworkCore;
using System.Reactive.Subjects;

namespace MealPlanSystem;

public class MealPlanEntityRepository<T> : EntityFrameworkRepositoryBase<MealPlanDbContext, T>
    where T: class
{
    public MealPlanEntityRepository(MealPlanDbContext context, ISubject<ExpressionStarter<T>> subject) : base(context, subject)
    {
        base.OnReset.Subscribe(q => q.DefaultExpression = a => true);
    }
}
