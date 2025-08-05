using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DXApplication2.Repositories;

public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(string id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    Task BulkSaveAsync(IEnumerable<T> entities);
    Task UpdateAsync(string id, T entity);
    Task DeleteAsync(string id);
    string GetNextId(T entity);
}
