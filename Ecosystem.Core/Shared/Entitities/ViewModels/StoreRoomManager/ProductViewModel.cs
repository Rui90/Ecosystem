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
    public class ProductViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [Required]
        public string Name { get; set; }

        public decimal Quantity { get; set; }

        public QuantityMeasure Measure { get; set; }

        public virtual BrandViewModel? Brand { get; set; }

        public virtual ICollection<ProductPriceViewModel> Prices { get; set; }
    }

}
