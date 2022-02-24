using Core.Base.Interfaces;
using Core.Entitities;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.DomainServices.Interfaces
{
    public interface IVideoDomainService : ICrudDomainService<Video>
    {
        Task<PaginatedViewModel<Video>> FilterVideos(
            long videoDuration,
            TrainningGoal? trainningGoal,
            BodyArea? bodyArea
       );
    }
}
