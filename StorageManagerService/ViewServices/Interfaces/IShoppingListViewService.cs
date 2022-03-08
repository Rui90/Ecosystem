using Core.Base.Interfaces;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;

namespace StorageManagerService.ViewServices.Interfaces
{
    public interface IShoppingListViewService : ICrudViewService<ShoppingListViewModel, ShoppingList>
    {
    }
}
