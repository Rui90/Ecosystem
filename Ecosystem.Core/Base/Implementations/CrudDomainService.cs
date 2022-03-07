using AutoMapper;
using Core.Base.Interfaces;
using Core.Entitities;
using Ecosystem.Core.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Core.Base.Implementations
{
    public class CrudDomainService<T> : ICrudDomainService<T>
            where T : class, IEntity
    {
        public readonly ILogger<ICrudDomainService<T>> Logger;
        public readonly IRepository<T> _repository;
        public readonly IMapper Mapper;

        public CrudDomainService(
            ILogger<ICrudDomainService<T>> logger,
            IMapper mapper,
            IRepository<T> repository)
        {
            Logger = logger;
            _repository = repository;
            Mapper = mapper;
        }

        public virtual T Create(T entity)
        {
            return _repository.Create(entity);
        }

        public virtual void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public virtual PaginatedViewModel<T> GetAll(int currentPage, int pageSize, params Expression<Func<T, object>>[] includes)
        {
            return _repository.GetAll(currentPage, pageSize, includes);
        }

        public virtual T GetById(Guid id, params Expression<Func<T, object>>[] includes)
        {
            return _repository.GetById(id, includes);
        }

        public virtual T Update(Guid id, T entity)
        {
            return _repository.Update(entity);
            
        }
    }
}
