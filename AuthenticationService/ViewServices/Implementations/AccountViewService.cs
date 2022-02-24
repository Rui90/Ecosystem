using AuthenticationService.DomainServices;
using AuthenticationService.Entities;
using AuthenticationService.Entities.Domain;
using AutoMapper;
using Core.Entitities.Authentication;
using Core.Entitities.ViewModels.Authentication;

namespace AuthenticationService.ViewServices.Implementations
{
    public class AccountViewService : IAccountViewService
    {

        private readonly IMapper _mapper;
        private readonly IAccountDomainService _domainService;

        public AccountViewService(
            IMapper mapper,
            IAccountDomainService domainService)
        {
            _mapper = mapper;
            _domainService = domainService;
        }

        public async Task<UserViewModel> Register(SignUpViewModel userViewModel)
        {
            return _mapper.Map<UserViewModel>(
                await _domainService.Register(_mapper.Map<User>(userViewModel), userViewModel.Password));
        }
    }
}
