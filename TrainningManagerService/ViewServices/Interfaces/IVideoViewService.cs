using Core.Base.Interfaces;
using Core.Entitities.ViewModels.TrainningManager;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.ViewServices.Interfaces
{
    public interface IVideoViewService : ICrudViewService<VideoViewModel, Video>
    {
        Task<VideoViewModel> GetRandomVideo(string? search,
            BodyArea? bodyArea,
            TrainningGoal? trainningGoal,
            long? maxDuration,
            long? minDuration);
    }
}
