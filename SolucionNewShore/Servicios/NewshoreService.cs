using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using SolucionNewShore.Modelos;
using System.Net;

namespace SolucionNewShore.Servicios
{
    public class NewshoreService
    {
        public async Task<List<Vuelos>> obtenerVuelos()
        {
            var httpClient = new HttpClient();
            string url = "https://recruiting-api.newshore.es/api/flights/1";
            var json = await httpClient.GetStringAsync(url);
            var listaVuelos = JsonConvert.DeserializeObject<List<Vuelos>>(json);

            return (listaVuelos);
        }
    }
}
