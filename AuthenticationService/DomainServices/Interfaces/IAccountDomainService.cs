using AuthenticationService.Entities;
using AuthenticationService.Entities.Domain;

namespace AuthenticationService.DomainServices
{
    public interface IAccountDomainService
    {
        Task<User> Register(User user, string password);
    }
}
