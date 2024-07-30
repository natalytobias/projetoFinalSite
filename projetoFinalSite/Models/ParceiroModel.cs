namespace projetoFinalSite.Models
{
    public class ParceiroModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Site { get; set; }

        public string Endereco { get; set; }

        public byte[] SenhaHash { get; set; }
        public byte[] SenhaSalt { get; set; }

    }
}
