namespace Core.Entitities
{
    public interface IEntity
    {
        Guid Id { get; set; }

        DateTimeOffset CreatedAt { get; set; }
    }
}
