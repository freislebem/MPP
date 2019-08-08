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
        public double Pernada { get; set; }

        public Diario Diario { get; set; }
        public Especie Especie { get; set; }
        public Isca Isca { get; set; }
        public Anzol Anzol { get; set; }

        public Item()
        {

        }

        public Item(int id, int idDiario, int idEspecie, int qtde, double tamanhoMaiorPeixe, double pesoMaiorPeixe, double pernada, Diario diario, Especie especie, Isca isca, Anzol anzol)
        {
            Id = id;
            IdDiario = idDiario;
            IdEspecie = idEspecie;
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
