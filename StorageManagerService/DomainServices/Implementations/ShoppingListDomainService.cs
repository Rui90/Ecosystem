using AutoMapper;
using Ecosystem.Services.Base.Implementations;
using Ecosystem.Services.Base.Interfaces;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;

namespace StorageManagerService.DomainServices.Implementations
{
    public class ShoppingListDomainService : CrudDomainService<ShoppingList>, IShoppingListDomainService
    {
        public ShoppingListDomainService(ILogger<IShoppingListDomainService> logger,
            IMapper mapper,
            IRepository<ShoppingList> repository) : base(logger, mapper, repository)
        {
        }
    }
}
