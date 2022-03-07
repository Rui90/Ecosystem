using Core.Entitities;
using System.Linq.Expressions;

namespace Core.Base.Interfaces
{
    public interface ICrudDomainService<T> 
    {
        PaginatedViewModel<T> GetAll(int currentPage, int pageSize, params Expression<Func<T, object>>[] includes);
        T Create(T entity);
        T Update(Guid id, T entity);
        void Delete(Guid id);
        T GetById(Guid id, params Expression<Func<T, object>>[] includes);
    }
}
