namespace Domain.Entities;

public class VoteEntity : BaseEntity
{
    public Guid UserId { get; private set; }
    public Guid CandidateId { get; private set; }
    public UserEntity? User { get; set; }
    public CandidateEntity? Candidate { get; set; }

    private VoteEntity()
    {
    }

    public VoteEntity(Guid userId, Guid candidateId)
    {
        UserId = userId;
        CandidateId = candidateId;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}