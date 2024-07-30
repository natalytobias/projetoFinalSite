using Microsoft.AspNetCore.Mvc;
using projetoFinalSite.Dto;
using projetoFinalSite.Services.LoginService;

namespace projetoFinalSite.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILoginInterface _loginInterface;

        public LoginController(ILoginInterface loginInterface) 
        { 
            _loginInterface = loginInterface;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(ParceiroRegisterDto parceiroRegisterDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _loginInterface.RegistrarParceiro(parceiroRegisterDto);

                if (user.Status)
                {
                    TempData["MensagemSucesso"] = user.Mensagem;
                }
                else
                {
                    TempData["MensagemErro"] = user.Mensagem;
                    return View(parceiroRegisterDto);
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View(parceiroRegisterDto);
            }
        }
    }
}
