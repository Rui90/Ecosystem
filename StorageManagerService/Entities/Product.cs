using Ecosystem.Shared.Entitities;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager.Enumerables;


namespace StorageManagerService.Entities
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Name { get; set; }

        public decimal Quantity { get; set; }

        public QuantityMeasure Measure { get; set; }

        public virtual Brand? Brand { get; set; }

        public virtual ICollection<ProductPrices> Prices { get; set; }
    }
}
