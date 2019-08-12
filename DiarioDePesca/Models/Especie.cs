
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

        [Display(Name = "Também conhecido como")]
        public string NomeB { get; set; }

        [Display(Name = "Nome científico")]
        public string NomeCientifico { get; set; }

        public Item Item { get; set; }

        public Especie()
        {

        }

        public Especie(int id, string nome, string nomeB, string nomeCientifico, Item item)
        {
            Id = id;
            Nome = nome;
            NomeB = nomeB;
            NomeCientifico = nomeCientifico;
            Item = item;
        }
    }
}
