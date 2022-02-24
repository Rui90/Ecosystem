using AutoMapper;
using Core.Base.Interfaces;
using Core.Entitities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<T> Create(T entity)
        {

            return Mapper.Map<T>(
                await DomainService.Create(Mapper.Map<K>(entity)));
        }

        public async Task Delete(Guid id)
        {
            await DomainService.Delete(id);
        }

        public PaginatedViewModel<T> GetAll(int currentPage, int pageSize)
        {
            var result = DomainService.GetAll(currentPage, pageSize);
            return new PaginatedViewModel<T>(result.Entries.Select(r => Mapper.Map<T>(r)).ToList(), 
                result.TotalEntries);
        }

        public async Task<T> Update(Guid id, T entity)
        {
            return Mapper.Map<T>(
                  await DomainService.Update(id, Mapper.Map<K>(entity)));
        }
    }
}
