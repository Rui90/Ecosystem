using Core.Base.Interfaces;
using Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.ViewServices.Interfaces
{
    public interface IVideoViewService : ICrudViewService<VideoViewModel, Video>
    {
    }
}
