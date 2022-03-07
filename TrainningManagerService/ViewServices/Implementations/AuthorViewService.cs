using AutoMapper;
using Core.Base.Implementations;
using Core.Base.Interfaces;
using Ecosystem.Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.ViewServices.Implementations
{
    public class AuthorViewService : CrudViewService<AuthorViewModel, Author>, IAuthorViewService
    {
        public AuthorViewService(ILogger<ICrudViewService<AuthorViewModel, Author>> logger, 
            IMapper mapper, 
            IAuthorDomainService domainService) : base(logger, mapper, domainService)
        {
        }
    }
}
