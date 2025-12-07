using System.Linq.Expressions;
using TechStore.Entities.Abstract;

namespace TechStore.Business.Abstract;

public interface IGenericService<T> where T : class,IEntity,new()
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}
