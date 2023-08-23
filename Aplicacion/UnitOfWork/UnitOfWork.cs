using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApiIncidenciasIIContext context;
        private PaisRepository _paises;
        public UnitOfWork(ApiIncidenciasIIContext _context)
        {
            context = _context;
        }
        public IPaisRepository Paises
        {
            get
            {
                _paises ??= new PaisRepository(context);
                return _paises;
            }
        }
        public int Save(){
            return context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<int> SaveAsync() => await context.SaveChangesAsync();
    }
}