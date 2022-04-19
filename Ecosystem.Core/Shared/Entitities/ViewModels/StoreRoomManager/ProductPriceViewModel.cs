using Ecosystem.Shared.Entitities;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager.Enumerables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager
{
    public class ProductPriceViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public QuantityMeasure Measure { get; set; }

        public virtual StoreViewModel? Store { get; set; }
        public virtual ProductViewModel Product { get; set; }
    }
}
