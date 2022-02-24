using AutoMapper;
using Core.Base.Interfaces;
using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Core.Base.Implementations
{
    public class CrudDomainService<T> : ICrudDomainService<T>
            where T : class, IEntity
    {
        public readonly ILogger<ICrudDomainService<T>> Logger;
        public readonly DbContext DbContext;
        public readonly IMapper Mapper;

        public CrudDomainService(
            ILogger<ICrudDomainService<T>> logger,
            IMapper mapper,
            DbContext dbContext)
        {
            Logger = logger;
            DbContext = dbContext;
            Mapper = mapper;
        }

        public async Task<T> Create(T entity)
        {
            var mappedEntitiy = Mapper.Map<T>(entity);
            DbContext.Add(mappedEntitiy);
            mappedEntitiy.CreatedAt = DateTime.UtcNow;
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(Guid id)
        {
            var entity = await DbContext.FindAsync<T>(id);
            if (entity != null)
            {
                DbContext.Remove(entity);
                await DbContext.SaveChangesAsync();
            }
        }

        public PaginatedViewModel<T> GetAll(int currentPage, int pageSize)
        {
            var counter = DbContext.Set<T>().Count();
            var entries = DbContext.Set<T>()
                .OrderBy(x => x.CreatedAt)
                .Skip(currentPage)
                .Take(pageSize);

            return new PaginatedViewModel<T>(entries.ToList(), counter);
        }

        public async Task<T> Update(Guid id, T entity)
        {
            var foundEntity = await DbContext.FindAsync<T>(id);
            if (foundEntity != null)
            {
                var mappedEntity = Mapper.Map<T>(entity);
                DbContext.Update(mappedEntity);
                await DbContext.SaveChangesAsync();
            }
            return entity;
        }
    }
}
