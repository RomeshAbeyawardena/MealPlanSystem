using AutoMapper;
using RST.Automapper.Extensions;

namespace MealPlanSystem.Api.Features.MealPlanEntryType;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap<PlanEntryType, MealPlanSystem.Features.MealPlanEntryType.PlanEntryType>().ReverseMap();
        this.CreatePagedMapping<MealPlanSystem.Features.MealPlanEntryType.PlanEntryType, PlanEntryType>();
    }
}
