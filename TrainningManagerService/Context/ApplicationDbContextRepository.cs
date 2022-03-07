using Core.Entitities;
using Ecosystem.Core.Base.Implementations;
using Microsoft.EntityFrameworkCore;

namespace TrainningManagerService.Context
{
    public class ApplicationDbContextRepository<T> : Repository<T> where T : class, IEntity
    {
        public ApplicationDbContextRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
