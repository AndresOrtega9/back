using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Domain.Entities;

namespace PruebaTecnica.Application.Interfaces
{
    public interface IGifService
    {
        Task<string> ObtenerUrlGifAsync(string query);
    }
}
