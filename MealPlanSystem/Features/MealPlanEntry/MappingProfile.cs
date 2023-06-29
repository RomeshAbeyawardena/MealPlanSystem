using AutoMapper;

namespace MealPlanSystem.Features.MealPlanEntry;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PagedQuery, Query>();
        CreateMap<SaveCommand, PlanEntry>();
    }
}
