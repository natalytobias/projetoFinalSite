
using projetoFinalSite.Dto;
using projetoFinalSite.Models;

namespace projetoFinalSite.Services.LoginService

{
    public interface ILoginInterface 
    {   
        //retorno assicrono - task
        Task<ResponseModel<ParceiroModel>>RegistrarParceiro(ParceiroRegisterDto parceiroRegisterDto);





        
    }
}
