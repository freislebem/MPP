using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public DateTime DtaPescaria { get; set; }
        public int Qtde { get; set; }

        public double TamanhoMaiorPeixe { get; set; }
        public double PesoMaiorPeixe { get; set; }
        public double Pernada { get; set; }

        public Diario Diario { get; set; }

        public int EspecieId { get; set; }
        public Especie Especie { get; set; }

        public int IscaId { get; set; }
        public Isca Isca { get; set; }

        public int AnzolId { get; set; }
        public Anzol Anzol { get; set; }

        public Item()
        {

        }

        public Item(int itemId, DateTime dtaPescaria, int qtde, double tamanhoMaiorPeixe, double pesoMaiorPeixe, double pernada, Diario diario, Especie especie, Isca isca, Anzol anzol)
        {
            ItemId = itemId;
            DtaPescaria = dtaPescaria;
            Qtde = qtde;
            TamanhoMaiorPeixe = tamanhoMaiorPeixe;
            PesoMaiorPeixe = pesoMaiorPeixe;
            Pernada = pernada;
            Diario = diario;
            Especie = especie;
            Isca = isca;
            Anzol = anzol;
        }
    }
}
