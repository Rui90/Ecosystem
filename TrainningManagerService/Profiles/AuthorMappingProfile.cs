using AutoMapper;
using Ecosystem.Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.Profiles
{
    public class AuthorMappingProfile : Profile
    {
        public AuthorMappingProfile()
        {

            CreateMap<AuthorViewModel, Author>()
                    .ReverseMap();
        }

    }
}
