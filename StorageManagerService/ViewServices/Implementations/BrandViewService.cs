using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
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
