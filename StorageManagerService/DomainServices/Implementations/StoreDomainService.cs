using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Base.Interfaces;
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
