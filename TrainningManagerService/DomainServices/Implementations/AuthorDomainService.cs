using AutoMapper;
using Core.Base.Implementations;
using Core.Base.Interfaces;
using Ecosystem.Core.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using TrainningManagerService.Context;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.DomainServices.Implementations
{
    public class AuthorDomainService : CrudDomainService<Author>, IAuthorDomainService
    {
        public AuthorDomainService(ILogger<ICrudDomainService<Author>> logger, 
            IMapper mapper,
            IRepository<Author> repository) : base(logger, mapper, repository)
        {
        }
    }
}
