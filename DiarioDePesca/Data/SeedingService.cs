using DiarioDePesca.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace DiarioDePesca.Data
{
    public class SeedingService
    {
        private EspecieContext _context;

        public SeedingService(EspecieContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Diario.Any() ||
                _context.Item.Any() ||
                _context.Usuario.Any())
            {
                return;
            }
            // aqui poderia popular o BD para testes
        }
    }
}
