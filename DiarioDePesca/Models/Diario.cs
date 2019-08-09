using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DiarioDePesca.Models
{
    public class Diario
    {
        public int Id { get; set; }
        public DateTime DtaRegistro { get; set; }

        [Display(Name = "Data da pescaria")]
        [Required(ErrorMessage = "A data da pescaria é obrigatória")]
        public DateTime DtaPescaria { get; set; }

        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Praia { get; set; }
        public string Local { get; set; }

        public double Temperatura { get; set; }

        [Display(Name = "Pressão atmosférica")]
        public double Pressao { get; set; }

        [Display(Name = "Horário da maré cheia")]
        public DateTime HorMareCheia{ get; set; }

        [Display(Name = "Medida da maré cheia")]
        public double MareCheia { get; set; }

        [Display(Name = "Horário da maré vazia")]
        public DateTime HorMareVazia { get; set; }

        [Display(Name = "Medida da maré vazia")]
        public double MareVazia { get; set; }

        [Display(Name = "Condição do dia")]
        public string CondicaoDia { get; set; }
        public string Lua { get; set; }

        [Display(Name = "Cor da água")]
        public string CorAgua { get; set; }

        public string Anzol { get; set; }

        [Display(Name = "Observações")]
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

        //   public int TotalPeixes(DateTime inicial, DateTime final)
        //   {
        //       return Items.Where(Diario => item.)
        //}
    }

}
