namespace Domain.Entities;

public class BaseEntity
{
    public Guid Id { get;protected set; }
    public DateTimeOffset CreatedAt { get;protected set; }
    public DateTimeOffset UpdatedAt { get;protected set; }
}