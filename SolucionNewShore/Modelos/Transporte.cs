namespace SolucionNewShore.Modelos
{
    public class Transporte
    {
        public string CompaniaAerea { get; set; } = string.Empty;
        public string NumeroDeVuelo { get; set; } = string.Empty;

        public Transporte(string companiaAerea, string numeroDeVuelo)
        {
            this.CompaniaAerea = companiaAerea;
            this.NumeroDeVuelo = numeroDeVuelo;    
        }

        public Transporte()
        {
            
        }
    }
}
