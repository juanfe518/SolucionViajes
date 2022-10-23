namespace SolucionNewShore.Modelos
{
    public class Transporte
    {
        public string companiaAerea { get; set; } = string.Empty;
        public string numeroDeVuelo { get; set; } = string.Empty;

        public Transporte(string companiaAerea, string numeroDeVuelo)
        {
            this.companiaAerea = companiaAerea;
            this.numeroDeVuelo = numeroDeVuelo;    
        }

        public Transporte()
        {
            
        }
    }
}
