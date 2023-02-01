using System.Linq.Expressions;

namespace QuizMVC.Repositories.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable <T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
    //IEnumerable <T> Find(Expression < Func <T, bool>> expression);
    Task<int> GetLastId(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Expression<Func<T, int>> max = null);
    Task Add(T entity);
    Task Update(T entity);
    Task DeleteCompletely(T entity);
}