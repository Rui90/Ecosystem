using Ecosystem.Services.Base;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.Controllers
{
    public class ShoppingListController : CrudController<ShoppingListViewModel, ShoppingList>
    {
        public ShoppingListController(
            ILogger<CrudController<ShoppingListViewModel, ShoppingList>> logger,
            IShoppingListViewService viewService) : base(logger, viewService)
        {
        }
    }
}
