using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Diario
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        //public DateTime DataPescaria { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Local { get; set; }
        public string PressaoA { get; set; }
        public string MareCheia { get; set; }
        public string MareVazia { get; set; }

        public string CondicaoDia { get; set; }
        public string Lua { get; set; }
        public string CorAgua { get; set; }

        public string Anzol { get; set; }
        public string Obs { get; set; }
    }
    
}
