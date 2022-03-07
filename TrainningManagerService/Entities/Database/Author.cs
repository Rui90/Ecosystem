using Core.Entitities;

namespace TrainningManagerService.Entities.Database
{
    public class Author : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}
