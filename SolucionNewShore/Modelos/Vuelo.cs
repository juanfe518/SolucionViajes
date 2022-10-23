using System.ComponentModel.DataAnnotations;

namespace SolucionNewShore.Modelos
{
    public class Vuelo
    {
        [Key]
        public int id { get; set; }
        public string origen { get; set; } = string.Empty;
        public string destino { get; set; } = string.Empty;
        public double precio { get; set; }
        public Transporte transporte { get; set; }

        public Vuelo(string origen, string destino, double precio, Transporte transporte)
        {
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
            this.transporte = transporte;
        }

        public Vuelo()
        {

        }
    }
}