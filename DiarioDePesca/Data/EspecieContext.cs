using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DiarioDePesca.Models
{
    public class EspecieContext : DbContext
    {
        public EspecieContext (DbContextOptions<EspecieContext> options)
            : base(options)
        {
        }

        public DbSet<Especie> Especie { get; set; }
        public DbSet<Diario> Diario { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<CondicaoDia> CondicaoDia { get; set; }
        public DbSet<CorAgua> CorAgua { get; set; }
        public DbSet<Isca> Isca { get; set; }
        public DbSet<Anzol> Anzol { get; set; }
    }
}
