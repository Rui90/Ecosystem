using Microsoft.AspNetCore.Identity;

namespace AuthenticationService.Entities
{
    public class User : IdentityUser<Guid> 
    {
        private string Password { get; set; }
    }

    public class UserLogin : IdentityUserLogin<Guid> { }

    public class UserRole : IdentityUserRole<Guid> { }

    public class UserClaim : IdentityUserClaim<Guid> { }

    public class Role : IdentityRole<Guid> { }
}
