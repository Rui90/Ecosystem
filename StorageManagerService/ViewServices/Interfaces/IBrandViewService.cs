using Ecosystem.Services.Base.Interfaces;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;

namespace StorageManagerService.ViewServices.Interfaces
{
    public interface IBrandViewService : ICrudViewService<BrandViewModel, Brand>
    {
    }
}
