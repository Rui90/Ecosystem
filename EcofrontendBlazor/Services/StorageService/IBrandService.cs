using Ecosystem.Shared.Entitities;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;

namespace Ecofrontend.Services.StorageService
{
    public interface IBrandService
    {
        Task<PaginatedViewModel<BrandViewModel>> GetBrands();
    }
}
