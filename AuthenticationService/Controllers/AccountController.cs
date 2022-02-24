using AuthenticationService.ViewServices;
using Core.Entitities.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IAccountViewService _viewService; 
        public AccountController(IAccountViewService viewService)
        {
            _viewService = viewService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(SignUpViewModel userViewModel)
        {
            return Ok(_viewService.Register(userViewModel));
        }

    }
}