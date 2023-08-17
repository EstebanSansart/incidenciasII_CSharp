using System.Net.Sockets;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repository;
public class GenericRepository<T> : IGenericRepository<T> where T : EntidadBase
{
    private readonly ApiIncidenciasIIContext _context;

    public GenericRepository(ApiIncidenciasIIContext contex)
    {
        _context = contex;
    }

    public virtual void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public virtual void AddRange (IEnumerable<T> entitites)
    {
        _context.Set<T>().AddRange(entitites);
    }

    public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public Task<T> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public virtual void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public virtual void Update(T entity)
    {
        _context.Set<T>()
        .Update(entity);
    }
}