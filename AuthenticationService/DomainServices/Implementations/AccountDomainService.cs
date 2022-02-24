using AuthenticationService.Entities;
using AuthenticationService.Entities.Domain;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationService.DomainServices.Implementations
{
    public class AccountDomainService : IAccountDomainService
    {
        private readonly UserManager<User> _userManager;

        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public AccountDomainService(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<User> Register(User user, string password)
        {
            return _mapper.Map<User>(await _userManager.CreateAsync(user, password));
        }
    }
}
