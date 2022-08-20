using System.Linq.Expressions;

namespace Joota.com.Data.Services
{
    public interface IEntityBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsyn();

        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties); 
        Task<T> GetShoesByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}