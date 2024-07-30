using projetoFinalSite.Data;
using projetoFinalSite.Dto;
using projetoFinalSite.Models;
using projetoFinalSite.Services.SenhaService;

namespace projetoFinalSite.Services.LoginService
{
    public class LoginService : ILoginInterface
    {
        private readonly ApplicationDbContext _context;
        private readonly ISenhaInterface _senhaInterface;

        public LoginService(ApplicationDbContext context, ISenhaInterface senhaInterface)
        {
            _context = context;
            _senhaInterface = senhaInterface;
        }


        public async Task<ResponseModel<ParceiroModel>> RegistrarParceiro(ParceiroRegisterDto parceiroRegisterDto)
        {
            ResponseModel<ParceiroModel> response = new ResponseModel<ParceiroModel>();

            try
            {
                if(VerificarSeEmailExiste(parceiroRegisterDto))
                {
                    response.Mensagem = "Email já cadastrado";
                    response.Status = false;
                    return response;
                }


                _senhaInterface.CriarSenhaHash(parceiroRegisterDto.Senha, out byte[] senhaHash, out byte[] senhaSalt);


                var parceiro = new ParceiroModel()
                {
                    Nome = parceiroRegisterDto.Nome,
                    Email = parceiroRegisterDto.Email,
                    Endereco = parceiroRegisterDto.Endereco,
                    Site = parceiroRegisterDto.Site


                };

                _context.Add(parceiro);
                await _context.SaveChangesAsync();

                response.Mensagem = "usuario cadastrado com sucesso";

                return response;
            
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;

            }
        }


        private bool VerificarSeEmailExiste(ParceiroRegisterDto parceiroRegisterDto)
        {

            var user = _context.Parceiro.FirstOrDefault(x => x.Email == parceiroRegisterDto.Email);

            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}
