using Ecosystem.Shared.Entitities;
using System.Linq.Expressions;

namespace Ecosystem.Services.Base.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class, IEntity
    {

        PaginatedViewModel<T> GetAll(int currentPage, int pageSize, params Expression<Func<T, object>>[] includes);
        T Create(T entity);
        T Update(T entity);
        void Delete(Guid id);
        T GetById(Guid id, params Expression<Func<T, object>>[] includes);
        IQueryable<T> GetQueryable(params Expression<Func<T, object>>[] includes);
    }
}
