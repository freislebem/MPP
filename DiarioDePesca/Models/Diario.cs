using System;
using System.Collections.Generic;
using System.Linq;

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
        public double Pressao { get; set; }

        public DateTime HorMareCheia{ get; set; }
        public double MareCheia { get; set; }

        public DateTime HorMareVazia { get; set; }
        public double MareVazia { get; set; }

        public string CondicaoDia { get; set; }
        public string Lua { get; set; }
        public string CorAgua { get; set; }

        public string Anzol { get; set; }
        public string Obs { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
        public CondicaoDia CondicaoDias { get; set; }
        public CorAgua CorAguas { get; set; }

        public Diario()
        {

        }

        public Diario(int id, DateTime dtaRegistro, DateTime dtaPescaria, string uf, string cidade, string praia, string local, double temperatura, double pressao, DateTime horMareCheia, double mareCheia, DateTime horMareVazia, double mareVazia, string condicaoDia, string lua, string corAgua, string anzol, string obs, CondicaoDia condicaoDias, CorAgua corAguas)
        {
            Id = id;
            DtaRegistro = dtaRegistro;
            DtaPescaria = dtaPescaria;
            Uf = uf;
            Cidade = cidade;
            Praia = praia;
            Local = local;
            Temperatura = temperatura;
            Pressao = pressao;
            HorMareCheia = horMareCheia;
            MareCheia = mareCheia;
            HorMareVazia = horMareVazia;
            MareVazia = mareVazia;
            CondicaoDia = condicaoDia;
            Lua = lua;
            CorAgua = corAgua;
            Anzol = anzol;
            Obs = obs;
            CondicaoDias = condicaoDias;
            CorAguas = corAguas;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public int TotalPeixes(DateTime inicial, DateTime final)
        {
            return Items.Where(Diario => item.)
        }
    }
    
}
