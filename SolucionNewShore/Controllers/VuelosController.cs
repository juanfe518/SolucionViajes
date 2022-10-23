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
            var ciudadOrigen = await _newshoreService.obtenerVuelos();
            var ciudadOrigen2 = from co in _newshoreService.obtenerVuelos().Result where co.departureStation == prueba select co;

            return Ok(ciudadOrigen2);
        }

        [HttpGet("viaje")]
        public ActionResult<Vuelos> getRutas()
        { 
           var listavuelos = _newshoreService.obtenerVuelos();
                
            return Ok(listavuelos);
        }
    }
}
