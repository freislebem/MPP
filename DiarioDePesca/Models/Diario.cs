using System;
using System.Collections.Generic;

namespace DiarioDePesca.Models
{
    public class Diario
    {
        public int Id { get; set; }
        public DateTime DtaRegistro { get; set; }
        public DateTime DtaPescaria { get; set; }

        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Praia { get; set; }
        public string Local { get; set; }

        public double Temperatura { get; set; }
        public string Pressao { get; set; }
        public string MareCheia { get; set; }
        public string MareVazia { get; set; }

        public string CondicaoDia { get; set; }
        public string Lua { get; set; }
        public string CorAgua { get; set; }

        public string Anzol { get; set; }
        public string Obs { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<CondicaoDia> CondicaoDias { get; set; } = new List<CondicaoDia>();
        public ICollection<CorAgua> CorAguas { get; set; } = new List<CorAgua>();
    }
    
}
