using AutoMapper;
using Ecosystem.Services.Base.Implementations;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using Ecosystem.Services.Base.Implementations;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.ViewServices.Implementations
{
    public class BrandViewService :
        CrudViewService<BrandViewModel, Brand>,
        IBrandViewService
    {
        public BrandViewService(
            ILogger<IBrandViewService> logger,
            IMapper mapper,
            IBrandDomainService domainService) : base(logger, mapper, domainService)
        {
        }
    }
}
