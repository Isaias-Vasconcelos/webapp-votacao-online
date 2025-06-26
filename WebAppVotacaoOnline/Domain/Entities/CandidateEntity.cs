namespace Domain.Entities;

public class CandidateEntity:BaseEntity
{
    public string? Name { get;private set; }
    public string? PhotoUrl { get;private set; }
    public int TotalVotes { get;private set; }
    public Guid CategoryId { get;private set; }
    public CategoryEntity? Category { get; set; }
    public ICollection<VoteEntity>? Votes { get; set; }
    private CandidateEntity()
    {
    }

    public CandidateEntity(string name, string photoUrl, Guid categoryId)
    {
        Id = Guid.NewGuid();
        Name = name;
        PhotoUrl = photoUrl;
        CategoryId = categoryId;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public CandidateEntity(Guid id,string? name, string photoUrl, Guid categoryId, DateTimeOffset createdAt, DateTimeOffset updatedAt)
    {
        Id = id;
        Name = name;
        PhotoUrl = photoUrl;
        CategoryId = categoryId;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
}