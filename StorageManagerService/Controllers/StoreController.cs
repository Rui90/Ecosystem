using Ecosystem.Services.Base;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.Controllers
{
    public class StoreController : CrudController<StoreViewModel, Store>
    {
        public StoreController(
            ILogger<CrudController<StoreViewModel, Store>> logger,
            IStoreViewService viewService) : base(logger, viewService)
        {
        }
    }
}
