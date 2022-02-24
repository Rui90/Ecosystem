using Core.Entitities;

namespace Core.Base.Interfaces
{
    public interface ICrudViewService<T, K>
    {
        PaginatedViewModel<T> GetAll(int currentPage, int pageSize);
        Task<T> Create(T entity);
        Task<T> Update(Guid id, T entity);
        Task Delete(Guid id);
    }
}
