using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
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
