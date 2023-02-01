using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;
using QuizMVC.Repositories.Interfaces;

namespace QuizMVC.Repositories.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly QuizMvcDbContext _context;

    protected GenericRepository(QuizMvcDbContext context)
    {
        _context = context;
    }
    
    public async Task<T> GetByIdAsync(int id)
    {
        var data = await _context.Set<T>().FindAsync(id);
        
        if (data is null)
            throw new Exception("not found");
        
        return data;
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
    {
        IQueryable<T> query = _context.Set<T>();
        query = query.Where(filter);
        query = orderBy(query);
        return await query.ToListAsync();
    }

    public async Task<int> GetLastId(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Expression<Func<T, int>> max = null)
    {
        IQueryable<T> query = _context.Set<T>();
        query = orderBy(query);
        return await query.MaxAsync(max);
    }

    public async Task Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await SaveChangesAsync();
    }
    
    public async Task Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await SaveChangesAsync();
    }

    public async Task DeleteCompletely(T entity)
    {
        _context.Set<T>().Remove(entity);
        await SaveChangesAsync();
    }

    private async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}