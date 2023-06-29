using AutoMapper;

namespace MealPlanSystem.Features.MealPlanEntryType;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PagedQuery, Query>();
        CreateMap<SaveCommand, PlanEntryType>();
    }
}
