using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class CorAgua
    {
        public int Id { get; set; }

        [Display(Name ="Cor da água")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Descricao { get; set; }

        public Diario Diario { get; set; }

        public CorAgua()
        {

        }

        public CorAgua(int id, string descricao, Diario diario)
        {
            Id = id;
            Descricao = descricao;
            Diario = diario;
        }
    }
}
