using AutoMapper;
using Core.Entitities.ViewModels.TrainningManager;
using Ecosystem.Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.Profiles
{
    public class PlanMappingProfile : Profile
    {
        public PlanMappingProfile()
        {
            CreateMap<PlanViewModel, Plan>()
                .ForMember(dest => dest.Videos, opt => opt.Ignore());

            CreateMap<Plan, PlanViewModel>();
        }
    }
}
