using Ecosystem.Services.Base.Interfaces;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;

namespace StorageManagerService.ViewServices.Interfaces
{
    public interface IProductViewService : ICrudViewService<ProductViewModel, Product>
    {
    }
}
