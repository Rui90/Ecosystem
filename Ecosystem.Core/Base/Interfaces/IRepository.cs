using Core.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Core.Base.Interfaces
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
