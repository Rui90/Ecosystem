using Ecosystem.Shared.Entitities;

namespace Ecosystem.Services.Base.Interfaces
{
    public interface ICrudViewService<T, K>
    {
        PaginatedViewModel<T> GetAll(int currentPage, int pageSize);
        T Create(T entity);
        T Update(Guid id, T entity);
        void Delete(Guid id);
        T GetById(Guid id);
    }
}
