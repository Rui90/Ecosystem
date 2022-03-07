using Core.Base.Interfaces;
using Core.Entitities;
using Core.Entitities.ViewModels.TrainningManager;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.DomainServices.Interfaces
{
    public interface IVideoDomainService : ICrudDomainService<Video>
    {
        Task<PaginatedViewModel<Video>> FilterVideos(
            string? search,
            long? maxVideoDuration,
            TrainningGoal? trainningGoal,
            BodyArea? bodyArea
       );

        Task<Video> GetRandomVideo(string? search, 
            BodyArea? bodyArea, 
            TrainningGoal? trainningGoal, 
            long? maxDuration, 
            long? minDuration);
    }
}
