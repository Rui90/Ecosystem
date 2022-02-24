using Core.Entitities;

namespace TrainningManagerService.Entities.Database
{
    public class Plan : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public string Name { get; set; }

        public long DurationInSeconds { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}
