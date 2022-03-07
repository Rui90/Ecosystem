using AutoMapper;
using Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.Profiles
{
    public class VideoMappingProfile : Profile
    {

        public VideoMappingProfile()
        {
            CreateMap<VideoViewModel, Video>()
                .ReverseMap();
        }
    }
}
