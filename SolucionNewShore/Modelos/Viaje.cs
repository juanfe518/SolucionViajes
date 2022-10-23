using System.ComponentModel.DataAnnotations;

namespace SolucionNewShore.Modelos
{
    public class Viaje
    {
        [Key]
        public int id { get; set; }
        public string origen { get; set; } = string.Empty;
        public string destino { get; set; } = string.Empty;
        public double precio { get; set; }
        public List<Vuelo> vuelos { get; set; }

        public Viaje(string origen, string destino, double precio, List<Vuelo> vuelos)
        {
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
            this.vuelos = vuelos;
        }

        public Viaje()
        {

        }
    }
}
