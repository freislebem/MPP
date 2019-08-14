using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class CondicaoDia
    {
        [Key]
        public int CondicaoId { get; set; }

        [Display(Name ="Condição do dia")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Descricao { get; set; }

        public Diario Diario { get; set; }

        public CondicaoDia()
        {

        }

        public CondicaoDia(int condicaoId, string descricao, Diario diario)
        {
            CondicaoId = condicaoId;
            Descricao = descricao;
            Diario = diario;
        }
    }
}
