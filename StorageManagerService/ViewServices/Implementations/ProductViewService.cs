using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.ViewServices.Implementations
{
    public class ProductViewService :
        CrudViewService<ProductViewModel, Product>,
        IProductViewService
    {
        public ProductViewService(
            ILogger<IProductViewService> logger,
            IMapper mapper,
            IProductDomainService domainService) : base(logger, mapper, domainService)
        {
        }
    }
}
