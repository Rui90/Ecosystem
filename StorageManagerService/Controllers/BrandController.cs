using Core.Base;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.Controllers
{
    public class BrandController : CrudController<BrandViewModel, Brand>
    {
        public BrandController(
            ILogger<CrudController<BrandViewModel, Brand>> logger,
            IBrandViewService viewService) : base(logger, viewService)
        {
        }
    }
}
