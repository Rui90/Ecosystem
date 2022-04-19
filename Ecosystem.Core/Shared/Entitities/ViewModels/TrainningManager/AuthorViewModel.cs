using Ecosystem.Shared.Entitities;

namespace Ecosystem.Shared.Entitities.ViewModels.TrainningManager
{
    public class AuthorViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string Name { get; set; }
    }
}
