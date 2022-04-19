using AutoMapper;
using Ecosystem.Services.Base.Implementations;
using Ecosystem.Services.Base.Interfaces;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;

namespace StorageManagerService.DomainServices.Implementations
{
    public class ProductPricesDomainService : CrudDomainService<ProductPrices>, IProductPriceDomainService
    {
        public ProductPricesDomainService(ILogger<IProductPriceDomainService> logger,
            IMapper mapper,
            IRepository<ProductPrices> repository) : base(logger, mapper, repository)
        {
        }
    }
}
