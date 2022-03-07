using Core.Base;
using Ecosystem.Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.Controllers
{
    public class AuthorController : CrudController<AuthorViewModel, Video>
    {
        public AuthorController(
            ILogger<CrudController<AuthorViewModel, Video>> logger,
            IAuthorViewService viewService) : base(logger, viewService)
        {
        }
    }
}
