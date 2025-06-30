using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Application.Interfaces;
using PruebaTecnica.Domain.Entities;
using PruebaTecnica.Infrastructure.DTOs;

namespace PruebaTecnica.Infrastructure.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly HttpClient _httpClient;

        public CatFactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> ObtenerCatFactAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CatFactDTO>("https://catfact.ninja/fact");
            return response?.Fact ?? string.Empty;
        }
    }
}
