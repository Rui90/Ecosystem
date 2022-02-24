using Core.Entitities.Authentication;
using Core.Entitities.ViewModels.Authentication;

namespace AuthenticationService.ViewServices
{
    public interface IAccountViewService
    {
        Task<UserViewModel> Register(SignUpViewModel userViewModel); 
    }
}
