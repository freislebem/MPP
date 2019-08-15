using DiarioDePesca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Services
{
    public class CorAguaService
    {
        private readonly EspecieContext _context;

        public CorAguaService(EspecieContext context)
        {
            _context = context;
        }

        public List<CorAgua> FindAll()
        {
            return _context.CorAgua.ToList();
        }
    }
}
