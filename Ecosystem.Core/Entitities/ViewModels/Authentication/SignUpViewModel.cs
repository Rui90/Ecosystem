using System.ComponentModel.DataAnnotations;

namespace Core.Entitities.Authentication
{
    public class SignUpViewModel : IViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [MaxLength(512)]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
