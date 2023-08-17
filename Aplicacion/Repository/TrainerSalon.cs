using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class TrainerSalonRepository : GenericRepository<TrainerSalon>, ITrainerSalonRepository
{
    public TrainerSalonRepository(ApiIncidenciasIIContext contex) : base(contex)
    {
    }
}