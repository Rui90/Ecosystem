using AutoMapper;
using Ecosystem.Services.Base.Implementations;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.ViewServices.Implementations
{
    public class ShoppingListViewService : 
        CrudViewService<ShoppingListViewModel, ShoppingList>, 
        IShoppingListViewService
    {
        public ShoppingListViewService(
            ILogger<IShoppingListViewService> logger, 
            IMapper mapper, 
            IShoppingListDomainService domainService) : base(logger, mapper, domainService)
        {
        }
    }
}
