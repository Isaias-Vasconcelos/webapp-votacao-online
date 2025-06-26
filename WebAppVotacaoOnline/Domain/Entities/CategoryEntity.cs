namespace Domain.Entities;

public class CategoryEntity:BaseEntity
{
    public string? Title { get;private set; }
    public string? Description { get;private set; }
    public Guid VotingId { get;private set; }
    public ICollection<CandidateEntity>? Candidates { get; set; }

    private CategoryEntity()
    {
        
    }

    public CategoryEntity(string title, string description,Guid votingId, ICollection<CandidateEntity>? candidates)
    {
        Title = title;
        Description = description;
        VotingId = votingId;
        Candidates = candidates;
        CreatedAt = DateTimeOffset.Now;
        UpdatedAt = DateTimeOffset.Now;
    }
}