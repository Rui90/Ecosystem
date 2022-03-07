using Core.Entitities;

namespace Ecosystem.Core.Entitities.ViewModels.TrainningManager
{
    public class AuthorViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string Name { get; set; }
    }
}
