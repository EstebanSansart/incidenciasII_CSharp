using Dominio;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class RolRepository : GenericRepositoryB<Rol>, IRolRepository
{
    private readonly ApiIncidenciasIIContext _context;

    public RolRepository(ApiIncidenciasIIContext context) : base(context)
    {
        _context = context;
    }
}