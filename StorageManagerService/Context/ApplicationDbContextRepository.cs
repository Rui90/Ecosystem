using Core.Entitities;
using Ecosystem.Core.Base.Implementations;

namespace StorageManagerService.Context
{
    public class ApplicationDbContextRepository<T> : Repository<T> where T : class, IEntity
    {
        public ApplicationDbContextRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
