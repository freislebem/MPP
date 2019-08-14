using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Isca
    {
        [Key]
        public int IscaId { get; set; }
        public string Descricao { get; set; }
        public Item Item { get; set; }

        public Isca()
        {

        }

        public Isca(int iscaId, string descricao, Item item)
        {
            IscaId = iscaId;
            Descricao = descricao;
            Item = item;
        }
    }
}
