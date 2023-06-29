using AutoMapper;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace MealPlanSystem.Features.MealPlanEntry;

public class SaveHandler : RepositoryHandlerBase<SaveCommand, PlanEntry, PlanEntry>
{
    [Inject] protected IMapper? Mapper { get; set; }
    public SaveHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<PlanEntry> Handle(SaveCommand request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<PlanEntry>, cancellationToken);
    }
}
