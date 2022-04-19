using Ecosystem.Shared.Entitities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager
{
    public class StoreViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
