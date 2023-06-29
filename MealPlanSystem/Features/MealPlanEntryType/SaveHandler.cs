using AutoMapper;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace MealPlanSystem.Features.MealPlanEntryType;

public class SaveHandler : RepositoryHandlerBase<SaveCommand, PlanEntryType, PlanEntryType>
{
    [Inject] protected IMapper? Mapper { get; set; }
    public SaveHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<PlanEntryType> Handle(SaveCommand request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<PlanEntryType>, cancellationToken);
    }
}
