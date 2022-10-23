using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolucionNewShore.Modelos
{
    public class ViajeVuelo
    {
        [Key]
        public int id { get; set; }
        public List<Viaje> viaje { get; set; }
        public List<Vuelo> vuelo{ get; set; }
        

    }
}
