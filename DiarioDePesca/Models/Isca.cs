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
        public Item Item { get; set; }

        public Isca()
        {

        }

        public Isca(int id, string descricao, Item item)
        {
            Id = id;
            Descricao = descricao;
            Item = item;
        }
    }
}
