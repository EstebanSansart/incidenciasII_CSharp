using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class PaisRepository : GenericRepository<Pais>, IPaisRepository
{
    private readonly ApiIncidenciasIIContext _context;
    public PaisRepository(ApiIncidenciasIIContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _context.Paises
        .Include(p => p.Departamentos)
        .ToListAsync();
    }
}