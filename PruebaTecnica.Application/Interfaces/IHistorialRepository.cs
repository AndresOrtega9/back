using PruebaTecnica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Application.Interfaces
{
    public interface IHistorialRepository
    {
        Task CrearHistorialAsync(HistorialBusqueda historial);
        Task<List<HistorialBusqueda>> ObtenerHistorialsAsync();
    }
}
