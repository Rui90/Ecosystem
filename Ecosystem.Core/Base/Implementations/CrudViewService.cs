using AutoMapper;
using Core.Base.Interfaces;
using Core.Entitities;
using Microsoft.Extensions.Logging;

namespace Core.Base.Implementations
{
    public class CrudViewService<T, K> : ICrudViewService<T, K>
            where T : IViewModel
            where K : class, IEntity
    {

        public readonly ILogger<ICrudViewService<T, K>> Logger;
        public readonly IMapper Mapper;
        public readonly ICrudDomainService<K> DomainService;

        public CrudViewService(
            ILogger<ICrudViewService<T, K>> logger,
            IMapper mapper,
            ICrudDomainService<K> domainService)
        {
            Logger = logger;
            Mapper = mapper;
            DomainService = domainService;
        }

        public virtual T Create(T entity)
        {

            return Mapper.Map<T>(DomainService.Create(Mapper.Map<K>(entity)));
        }

        public virtual void Delete(Guid id)
        {
            DomainService.Delete(id);
        }

        public virtual PaginatedViewModel<T> GetAll(int currentPage, int pageSize)
        {
            var result = DomainService.GetAll(currentPage, pageSize);
            return new PaginatedViewModel<T>(result.Entries.Select(r => Mapper.Map<T>(r)).ToList(), 
                result.TotalEntries);
        }

        public virtual T GetById(Guid id)
        {
            return Mapper.Map<T>(DomainService.GetById(id));
        }

        public virtual T Update(Guid id, T entity)
        {
            return Mapper.Map<T>(DomainService.Update(id, Mapper.Map<K>(entity)));
        }
    }
}
