using Ecosystem.Shared.Entitities;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager.Enumerables;

namespace StorageManagerService.Entities
{
    public class ProductPrices : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public QuantityMeasure Measure { get; set; }
         
        public virtual Store? Store { get; set; }
        public virtual Product Product { get; set; }
    }
}
