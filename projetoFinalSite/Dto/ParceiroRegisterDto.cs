using System.ComponentModel.DataAnnotations;

namespace projetoFinalSite.Dto
{
    public class ParceiroRegisterDto
    {
        [Required(ErrorMessage ="Campo obrigatório")] 
        public string Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Site { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório"),
            Compare("Senha", ErrorMessage = "As senhas não estão iguais")]
        public string ConfirmaSenha { get; set; }
    }
}
