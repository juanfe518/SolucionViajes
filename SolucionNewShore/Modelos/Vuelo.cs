namespace SolucionNewShore.Modelos
{
    public class Vuelo
    {
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public double Precio { get; set; }
        public Transporte transporte { get; set; }

        public Vuelo(string origen, string destino, double precio, Transporte transporte)
        {
            this.Origen = origen;
            this.Destino = destino;
            this.Precio = precio;
            this.transporte = transporte;
        }

        public Vuelo()
        {

        }
    }
}