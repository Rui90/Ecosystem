using Core.Entitities;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;

namespace TrainningManagerService.Entities.Database
{
    public class Plan : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public string Name { get; set; }

        public TrainningGoal? TrainningGoal { get; set; }

        public virtual ICollection<Video> Videos { get; set; }

        public BodyArea BodyAreas { get; set; }

    }
}
