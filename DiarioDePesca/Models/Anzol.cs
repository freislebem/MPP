using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Anzol
    {
        [Key]
        public int AnzolId { get; set; }
        public string Descricao { get; set; }
        public Item Item { get; set; }
        
        public Anzol()
        {

        }

        public Anzol(int anzolId, string descricao, Item item)
        {
            AnzolId = anzolId;
            Descricao = descricao;
            Item = item;
        }
    }
}
