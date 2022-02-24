using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entitities.ViewModels.TrainningManager
{
    public class PlanViewModel : IViewModel
    {
        public string Name { get; set; }
        public long DurationInSeconds { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
