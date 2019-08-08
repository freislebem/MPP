using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Isca
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();

        public Isca()
        {

        }

        public Isca(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
