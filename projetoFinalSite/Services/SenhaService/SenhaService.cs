using System.Security.Cryptography;

namespace projetoFinalSite.Services.SenhaService
{
    public class SenhaService : ISenhaInterface
    {
        public void CriarSenhaHash(string senha, out byte[] senhahash, out byte[] senhaSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                senhaSalt = hmac.Key;
                senhahash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
            }
        }
    }
}
