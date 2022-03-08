using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;
using StorageManagerService.ViewServices.Interfaces;

namespace StorageManagerService.ViewServices.Implementations
{
    public class StoreViewService : CrudViewService<StoreViewModel, Store>, IStoreViewService
    {
        public StoreViewService(
            ILogger<IStoreViewService> logger, 
            IMapper mapper,
            IStoreDomainService domainService) : base(logger, mapper, domainService)
        {
        }
    }
}
