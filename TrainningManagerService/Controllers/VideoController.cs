using Core.Base;
using Core.Entitities.ViewModels.TrainningManager;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using Microsoft.AspNetCore.Mvc;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.Controllers
{
    public class VideoController : CrudController<VideoViewModel, Video>
    {

        private readonly IVideoViewService _videoViewService;

        public VideoController(
            ILogger<VideoController> logger,
            IVideoViewService viewService) : base(logger, viewService)
        {
            _videoViewService = viewService;
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandomVideo(
            string? search,
            BodyArea? bodyArea,
            TrainningGoal? trainningGoal,
            long? maxDuration,
            long? minDuration)
        {
            return Ok(await _videoViewService.GetRandomVideo(search, bodyArea, trainningGoal, maxDuration, minDuration));
        }
    }
}
