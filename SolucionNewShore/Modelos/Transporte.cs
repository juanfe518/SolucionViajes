using System.ComponentModel.DataAnnotations;

namespace SolucionNewShore.Modelos
{
    public class Transporte
    {
        [Key]
        public int id { get; set; }
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
