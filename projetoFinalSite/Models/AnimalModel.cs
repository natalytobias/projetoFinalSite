using projetoFinalSite;
using System.ComponentModel.DataAnnotations;

namespace projetoFinalSite.Models
{
    public class AnimalModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Opa! esqueceu um campo obrigatório")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Opa! esqueceu um campo obrigatório")]
        public string Porte { get; set; }

        [Required(ErrorMessage = "Opa! esqueceu um campo obrigatório")]
        public string Personalidade { get; set; }

        [Required(ErrorMessage = "Opa! esqueceu um campo obrigatório")]
        public string Natureza { get; set; }

        [Required(ErrorMessage = "Opa! esqueceu um campo obrigatório")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "Opa! esqueceu um campo obrigatório")]
        public string Cidade { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
