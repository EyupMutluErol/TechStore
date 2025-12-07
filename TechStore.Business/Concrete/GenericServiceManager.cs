using System.Linq.Expressions;
using TechStore.Business.Abstract;
using TechStore.DataAccess.Abstract;
using TechStore.Entities.Abstract;

namespace TechStore.Business.Concrete;

public class GenericServiceManager<T> : IGenericService<T> where T : class,IEntity,new()
{
    protected readonly IGenericRepository<T> _repository;

    public GenericServiceManager(IGenericRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(T entity)
    {
        await _repository.AddAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity != null) 
        {
            _repository.Delete(entity);
        }
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
    {
        return await _repository.GetAllAsync(filter);
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
        _repository.Update(entity);
        await Task.CompletedTask;
    }
}
