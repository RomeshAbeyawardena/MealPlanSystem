using AutoMapper;

namespace MealPlanSystem.Features.MealPlan;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PagedQuery, Query>();
        CreateMap<SaveCommand, Plan>();
    }
}
