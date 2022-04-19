using Ecosystem.Services.Base;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.Controllers
{
    public class ProductPriceController : CrudController<ProductPriceViewModel, ProductPrices>
    {
        public ProductPriceController(
            ILogger<CrudController<ProductPriceViewModel, ProductPrices>> logger,
            IProductPriceViewService viewService) : base(logger, viewService)
        {
        }
    }
}
