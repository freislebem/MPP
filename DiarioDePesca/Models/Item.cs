using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int IdDiario { get; set; }
        public int IdEspecie { get; set; }
        public int Qtde { get; set; }

        public double TamanhoMaiorPeixe { get; set; }
        public double PesoMaiorPeixe { get; set; }
        public string Isca { get; set; }
        public string Anzol { get; set; }
        public double Pernada { get; set; }

        public ICollection<Especie> Especies { get; set; } = new List<Especie>();
        public ICollection<Isca> Iscas { get; set; } = new List<Isca>();
        public ICollection<Anzol> Anzols { get; set; } = new List<Anzol>();
    }
}
