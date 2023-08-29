using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
public interface IGenericRepository<T> where T : EntidadBase
{
    Task<T> GetByIdAsync(string id);
    Task<IEnumerable<T>> GetAllAsync();
    IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search);
    void Add(T entity);
    void AddRange(IEnumerable<T> entitites);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entitites);
    void Update(T entity);
}