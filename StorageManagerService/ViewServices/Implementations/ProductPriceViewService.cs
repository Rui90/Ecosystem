using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.ViewServices.Implementations
{
    public class ProductPriceViewService :
        CrudViewService<ProductPriceViewModel, ProductPrices>,
        IProductPriceViewService
    {
        public ProductPriceViewService(
            ILogger<IProductPriceViewService> logger,
            IMapper mapper,
            IProductPriceDomainService domainService) : base(logger, mapper, domainService)
        {
        }
    }
}
