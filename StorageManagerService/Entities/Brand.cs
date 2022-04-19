using Ecosystem.Shared.Entitities;

namespace StorageManagerService.Entities
{
    public class Brand : IEntity
    {

        public Guid Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Name { get; set; }
    }
}
