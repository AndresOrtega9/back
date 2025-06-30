using Newtonsoft.Json;
using PruebaTecnica.Application.Interfaces;
using PruebaTecnica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static PruebaTecnica.Infrastructure.DTOs.GiphyDTO;

namespace PruebaTecnica.Infrastructure.Services
{
    public class GifService : IGifService
    {
        private readonly HttpClient _httpClient;
        private const string apiKey = "voaNIOg1u7ONPbckzWK71C48YqCOkhVP";

        public GifService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ObtenerUrlGifAsync(string query)
        {
            var encoded = Uri.EscapeDataString(query);
            var url = $"https://api.giphy.com/v1/gifs/search?api_key={apiKey}&q={encoded}&limit=50";
            var response = await _httpClient.GetFromJsonAsync<GiphyRespuesta>(url);

            if (response?.data == null || response.data.Count == 0)
            {
                return "No se han encontrado datos";
            }
              
            var random = new Random();
            var id = random.Next(0, response.data.Count);
            return response.data[id].images?.original?.url ?? "No se han encontrado datos";
        }
    }
}