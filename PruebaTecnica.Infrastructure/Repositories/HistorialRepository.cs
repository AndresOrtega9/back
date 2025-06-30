using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using PruebaTecnica.Application.Interfaces;
using PruebaTecnica.Domain.Entities;
using PruebaTecnica.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Infrastructure.Repositories
{
    public class HistorialRepository : IHistorialRepository
    {
        private readonly AppDbContext _dbContext;

        public HistorialRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CrearHistorialAsync(HistorialBusqueda historial)
        {
            _dbContext.Historial.Add(historial);
            await _dbContext.SaveChangesAsync();
        }

        [HttpGet]
        public async Task<List<HistorialBusqueda>> ObtenerHistorialsAsync()
        {
            var resultado = await _dbContext.Historial
                .OrderByDescending(r => r.FechaConsulta)
                .FirstOrDefaultAsync();

            return resultado != null ? new List<HistorialBusqueda> { resultado } : new List<HistorialBusqueda>();
        }
    }
}
