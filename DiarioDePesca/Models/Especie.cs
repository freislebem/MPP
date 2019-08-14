
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiarioDePesca.Models
{
    public class Especie
    {
        [Key]
        public int EspecieId { get; set; }

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

        public Especie(int especieId, string nome, string nomeB, string nomeCientifico, Item item)
        {
            EspecieId = especieId;
            Nome = nome;
            NomeB = nomeB;
            NomeCientifico = nomeCientifico;
            Item = item;
        }
    }
}
