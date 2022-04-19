using Ecosystem.Shared.Entitities;

namespace StorageManagerService.Entities
{
    public class ShoppingList : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
