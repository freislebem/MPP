using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class CorAgua
    {
        [Key]
        public int CorAguaId { get; set; }

        [Display(Name ="Cor da água")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Descricao { get; set; }

        public Diario Diario { get; set; }

        public CorAgua()
        {

        }

        public CorAgua(int corAguaId, string descricao, Diario diario)
        {
            CorAguaId = corAguaId;
            Descricao = descricao;
            Diario = diario;
        }
    }
}
