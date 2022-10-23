namespace SolucionNewShore.Modelos
{
    public class Viaje
    {
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public double precio { get; set; }
        public List<Vuelo> Vuelos { get; set; }

        public Viaje(string Origen, string Destino, double precio, List<Vuelo> vuelos)
        {
            this.Origen = Origen;
            this.Destino = Destino;
            this.precio = precio;
            this.Vuelos = vuelos;
        }

        public Viaje()
        {

        }
    }
}
