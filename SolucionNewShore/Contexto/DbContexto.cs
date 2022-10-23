using Microsoft.EntityFrameworkCore;
using SolucionNewShore.Modelos;
using System.Collections.Generic;

namespace SolucionNewShore.Contexto
{
    public class DbContexto: DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
        }

        public DbSet<ViajeVuelo> Factura{ get; set; }
        public DbSet<Viaje> Viajes{ get; set; }
        public DbSet<Vuelo> Vuelos{ get; set; }
        public DbSet<Transporte> Transportes{ get; set; }
    
    }
}
