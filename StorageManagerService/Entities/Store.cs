using Ecosystem.Shared.Entitities;

namespace StorageManagerService.Entities
{
    public class Store : IEntity
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Name { get; set; }
    }
}
