namespace projetoFinalSite.Services.SenhaService
{
    public interface ISenhaInterface
    {

        void CriarSenhaHash(string senha, out byte[] senhahash, out byte[] senhaSalt); 
    }
}
