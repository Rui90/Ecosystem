using Core.Entitities;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using System.ComponentModel.DataAnnotations;

namespace TrainningManagerService.Entities.Database
{
    public class Video : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(512)]
        public string Url { get; set; }

        public BodyArea Area { get; set; }

        public TrainningGoal VideoGoal { get; set; }

        public bool EquipmentRequired { get; set; }

        public long DurationInSeconds { get; set; }

        public virtual ICollection<Plan> Plan { get; set; }
    }
}
