using AutoMapper;
using RST.Automapper.Extensions;

namespace MealPlanSystem.Api.Features.MealPlanEntry;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap<PlanEntry, MealPlanSystem.Features.MealPlanEntry.PlanEntry>().ReverseMap();
        this.CreatePagedMapping<MealPlanSystem.Features.MealPlanEntry.PlanEntry, PlanEntry>();
    }
}
