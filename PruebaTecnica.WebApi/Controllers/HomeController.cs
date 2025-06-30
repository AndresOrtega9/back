using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Application.Interfaces;
using PruebaTecnica.Domain.Entities;

namespace PruebaTecnica.WebApi.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : Controller
    {
        private readonly ICatFactService _catFactService;
        private readonly IGifService _gifService;
        private readonly IHistorialRepository _historialRepository;

        public HomeController(ICatFactService catFactService, IGifService gifService, IHistorialRepository historialRepository )
        {
            _catFactService = catFactService;
            _gifService = gifService;
            _historialRepository = historialRepository;
        }

        [HttpGet("gif-fact-nuevo")]
        public async Task<IActionResult> GestionarBusquedaGifConDatoAleatorio()
        {
            var fact = await _catFactService.ObtenerCatFactAsync();
            var query = string.Join(" ", fact.Split(' ').Take(3));
            var urlGif = await _gifService.ObtenerUrlGifAsync(query);

            var datosBusqueda = new HistorialBusqueda
            {
                Fact = fact,
                Query = query,
                Url = urlGif,
                FechaConsulta = DateTime.Now
            };

            await _historialRepository.CrearHistorialAsync(datosBusqueda);
            return Ok(datosBusqueda);
        }

        [HttpGet("gif-fact-existente")]
        public async Task<IActionResult> GestionarBusquedaGifConFactExistente(string fact)
        {
            var query = string.Join(" ", fact.Split(' ').Take(3));
            var urlGif = await _gifService.ObtenerUrlGifAsync(query);

            var datosBusqueda = new HistorialBusqueda
            {
                Fact = fact,
                Query = query,
                Url = urlGif,
                FechaConsulta = DateTime.Now
            };

            await _historialRepository.CrearHistorialAsync(datosBusqueda);
            return Ok(datosBusqueda);
        }

        [HttpGet("historial")]
        public async Task<List<HistorialBusqueda>> ObteterHistorial()
        {
            var lista = await _historialRepository.ObtenerHistorialsAsync();
            return lista.ToList();
        }
    }
}