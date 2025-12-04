using System.Linq.Expressions;
using TechStore.Entities.Abstract;

namespace TechStore.DataAccess.Abstract;

public interface IGenericRepository<T> where T : class , IEntity , new()
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
    Task<T> GetAsync(Expression<Func<T, bool>> filter);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}
