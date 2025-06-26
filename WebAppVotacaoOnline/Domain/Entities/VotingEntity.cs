namespace Domain.Entities;

public class VotingEntity : BaseEntity
{
    public Guid CreatorUserId { get;private set; }
    public string? Title { get; private set; }
    public string? Description { get; private set; }
    public ICollection<CategoryEntity>? Categories { get; set; }
    public UserEntity? User { get; set; }
    public int TotalVotes { get; private set; }

    private VotingEntity()
    {
    }

    public VotingEntity(Guid creatorUserId,string title, string description)
    {
        CreatorUserId = creatorUserId;
        Title = title;
        Description = description;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public VotingEntity(Guid id, Guid creatorUserId, string title, string description,int totalVotes, DateTimeOffset createdAt, DateTimeOffset updatedAt)
    {
        Id = id;
        CreatorUserId = creatorUserId;
        Title = title;
        Description = description;
        TotalVotes = totalVotes;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
}