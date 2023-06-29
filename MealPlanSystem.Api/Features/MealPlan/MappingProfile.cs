using AutoMapper;
using RST.Automapper.Extensions;

namespace MealPlanSystem.Api.Features.MealPlan;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap<Plan, MealPlanSystem.Features.MealPlan.Plan>().ReverseMap();
        this.CreatePagedMapping<MealPlanSystem.Features.MealPlan.Plan, Plan>();
    }
}
