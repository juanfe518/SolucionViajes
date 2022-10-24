using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolucionNewShore.Contexto;
using SolucionNewShore.Modelos;
using SolucionNewShore.Servicios;

namespace SolucionNewShore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VuelosController : ControllerBase
    {
        //esta es la capa de controlador

        //llamo la instancia de el servicio y el db context
        private readonly NewshoreService _newshoreService;
        private readonly DbContexto _contexto;
        public VuelosController(NewshoreService newshoreService, DbContexto contexto)
        {
            _newshoreService = newshoreService;
            _contexto = contexto;
        }

        //con este metodo compreubo que el servicio está funcionando correctamente
        [HttpGet]
        public async Task<ActionResult<List<Vuelos>>> obtenerListaVuelos()
        {
            string prueba = "CTG";
            List<Vuelos> ciudadOrigen = _newshoreService.obtenerVuelos().Result;
            var ciudadOrigen2 = from co in _newshoreService.obtenerVuelos().Result where co.departureStation == prueba select co;

            return Ok(ciudadOrigen2);
        }

        // este metodo devuelve el viaje especificado
        [HttpGet("viaje")]
        public async Task<ActionResult<List<Viaje>>> obtenerViaje(string origen, string destino)
        {
            var ciudadOrigen2 =  _newshoreService.viajes(origen, destino).Result;
            return Ok(ciudadOrigen2);
        }
    }
}
