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

        public DbSet<DiarioDePesca.Models.Especie> Especie { get; set; }
    }
}
