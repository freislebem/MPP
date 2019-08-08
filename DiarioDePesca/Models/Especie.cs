
using System.Collections.Generic;

namespace DiarioDePesca.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeB { get; set; }
        public string NomeCientifico { get; set; }

        public ICollection<Item> Items  { get; set; } = new List<Item>();

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
