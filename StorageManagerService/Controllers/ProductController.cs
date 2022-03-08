using Core.Base;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.Controllers
{
    public class ProductController : CrudController<ProductViewModel, Product>
    {
        public ProductController(
            ILogger<CrudController<ProductViewModel, Product>> logger,
            IProductViewService viewService) : base(logger, viewService)
        {
        }
    }
}
