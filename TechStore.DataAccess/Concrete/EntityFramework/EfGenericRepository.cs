using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TechStore.DataAccess.Abstract;
using TechStore.DataAccess.Concrete.Context;
using TechStore.Entities.Abstract;

namespace TechStore.DataAccess.Concrete.EntityFramework;

public class EfGenericRepository<T>:IGenericRepository<T> where T : class , IEntity , new()
{
    protected readonly TechStoreContext _context;

    public EfGenericRepository(TechStoreContext context)
    {
        _context = context;
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
    {
        return filter == null
            ? await _context.Set<T>().ToListAsync()
            : await _context.Set<T>().Where(filter).ToListAsync();
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(filter);
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }
}
