
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiarioDePesca.Models
{
    public class Especie
    {
        public int Id { get; set; }

        [Display(Name ="Nome do Peixe")]
        [Required(ErrorMessage = "É obrigatório informar o nome peixe")]
        public string Nome { get; set; }

        [Display(Name = "Peixe também conhecido como")]
        public string NomeB { get; set; }
        public string NomeCientifico { get; set; }

        //public ICollection<Item> Items  { get; set; } = new List<Item>();

        public Especie()
        {

        }

        public Especie(int id, string nome, string nomeB, string nomeCientifico)
        {
            Id = id;
            Nome = nome;
            NomeB = nomeB;
            NomeCientifico = nomeCientifico;
        }
    }
}
