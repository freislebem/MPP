using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiarioDePesca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string email { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string login { get; set; }
        public string celular { get; set; }

        public ICollection<Diario> Diarios { get; set; } = new List<Diario>();

        public Usuario()
        {

        }

        public Usuario(int id, string email, string login, string celular)
        {
            Id = id;
            this.email = email;
            this.login = login;
            this.celular = celular;
        }

        public void AddDiario(Diario diario)
        {
            Diarios.Add(diario);
        }

        public int TotalDiario(DateTime inicial, DateTime final)
        {
            return Diarios.Sum(diario => diario.TotalItens(inicial, final));
        }

    }

}
