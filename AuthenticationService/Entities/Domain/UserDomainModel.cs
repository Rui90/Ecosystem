using Core.Entitities;

namespace AuthenticationService.Entities.Domain
{
    public class UserDomainModel : IEntity
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
