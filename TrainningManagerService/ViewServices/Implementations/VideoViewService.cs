using AutoMapper;
using Core.Base.Implementations;
using Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.ViewServices.Implementations
{
    public class VideoViewService : CrudViewService<VideoViewModel, Video>, IVideoViewService
    {

        public VideoViewService(
            ILogger<IVideoViewService> logger,
            IMapper mapper,
            IVideoDomainService domainService) : base(logger, mapper, domainService)
        {
        }
    }
}
