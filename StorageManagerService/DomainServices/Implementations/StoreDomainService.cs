using AutoMapper;
using Ecosystem.Services.Base.Implementations;
using Ecosystem.Services.Base.Interfaces;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;

namespace StorageManagerService.DomainServices.Implementations
{
    public class StoreDomainService : CrudDomainService<Store>, IStoreDomainService
    {
        public StoreDomainService(ILogger<IStoreDomainService> logger,
            IMapper mapper,
            IRepository<Store> repository) : base(logger, mapper, repository)
        {
        }
    }
}
