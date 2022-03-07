using AutoMapper;
using Core.Base.Implementations;
using Core.Entitities.ViewModels.TrainningManager;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.ViewServices.Implementations
{
    public class VideoViewService : CrudViewService<VideoViewModel, Video>, IVideoViewService
    {
        private readonly IVideoDomainService _videoDomainService;

        public VideoViewService(
            ILogger<IVideoViewService> logger,
            IMapper mapper,
            IVideoDomainService domainService) : base(logger, mapper, domainService)
        {
            _videoDomainService = domainService;
        }

        public async Task<VideoViewModel> GetRandomVideo(string? search, BodyArea? bodyArea, TrainningGoal? trainningGoal, long? maxDuration, long? minDuration)
        {
            return Mapper.Map<VideoViewModel>(await _videoDomainService.GetRandomVideo(search, bodyArea, trainningGoal, maxDuration, minDuration));
        }
    }
}
