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


        public async Task<List<Viaje>> viajes(string origen, string destino)
        {
            var httpClient = new HttpClient();
            string url = "https://recruiting-api.newshore.es/api/flights/1";
            var json = await httpClient.GetStringAsync(url);
            var listaVuelos = JsonConvert.DeserializeObject<List<Vuelos>>(json);

            List<Viaje> viaje = new List<Viaje>();
            Transporte transporte = new Transporte();
            List<Vuelo> vuelo = new List<Vuelo>();

            foreach (var item in listaVuelos)
            {
                transporte = new Transporte(item.flightCarrier, item.flightNumber);
                vuelo.Add(new Vuelo(item.departureStation, item.arrivalStation, item.price, transporte));
            }
            var miViaje = (from v in vuelo where v.origen == origen && v.destino == destino select v).ToList();
            var valorViaje = (from v in miViaje select v.precio).Sum();
            viaje.Add( new Viaje(origen, destino, valorViaje, miViaje));

            return (viaje);
        }
    }
}
