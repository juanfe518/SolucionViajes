using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolucionNewShore.Modelos;
using SolucionNewShore.Servicios;

namespace SolucionNewShore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VuelosController : ControllerBase
    {
        private readonly NewshoreService _newshoreService;
        public VuelosController(NewshoreService newshoreService)
        {
            _newshoreService = newshoreService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vuelos>>> getViajes()
        {
            string prueba = "CTG";
            List<Vuelos> ciudadOrigen = _newshoreService.obtenerVuelos().Result;
            var ciudadOrigen2 = from co in _newshoreService.obtenerVuelos().Result where co.departureStation == prueba select co;

            return Ok(ciudadOrigen2);
        }

        [HttpGet("viaje")]
        public async Task<ActionResult<List<Viaje>>> getRutas(string origen, string destino)
        {
            var ciudadOrigen2 =  _newshoreService.viajes(origen, destino).Result;
            

            return Ok(ciudadOrigen2);
        }
    }
}
