using Core.Base;
using Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.Controllers
{
    public class VideoController : CrudController<VideoViewModel, Video>
    {

        public VideoController(
            ILogger<VideoController> logger,
            IVideoViewService viewService) : base(logger, viewService)
        {
        }
    }
}
