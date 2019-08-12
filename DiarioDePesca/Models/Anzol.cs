using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Anzol
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Item Item { get; set; }
        
        public Anzol()
        {

        }

        public Anzol(int id, string descricao, Item item)
        {
            Id = id;
            Descricao = descricao;
            Item = item;
        }
    }
}
