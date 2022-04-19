using Ecosystem.Services.Base.Implementations;
using Ecosystem.Shared.Entitities;

namespace StorageManagerService.Context
{
    public class ApplicationDbContextRepository<T> : Repository<T> where T : class, IEntity
    {
        public ApplicationDbContextRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
