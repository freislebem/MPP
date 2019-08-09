using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class CorAgua
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        //public Diario Diario { get; set; }

        public CorAgua()
        {

        }

        public CorAgua(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            //Diario = diario;
        }
    }
}
