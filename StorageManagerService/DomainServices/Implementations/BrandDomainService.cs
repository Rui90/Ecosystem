using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Base.Interfaces;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;

namespace StorageManagerService.DomainServices.Implementations
{
    public class BrandDomainService : CrudDomainService<Brand>, IBrandDomainService
    {
        public BrandDomainService(ILogger<IBrandDomainService> logger,
            IMapper mapper,
            IRepository<Brand> repository) : base(logger, mapper, repository)
        {
        }
    }
}
