namespace Domain.Entities;

public class UserEntity:BaseEntity
{
    public string? Name { get;private set; }
    public string? Email { get; private set; }
    public string? Password { get;private set; }
    public bool IsActive { get;private set; }
    public ICollection<VotingEntity>? Votings { get; set; }
    public ICollection<VoteEntity>? Votes { get; set; }

    private UserEntity()
    {
    }

    public UserEntity(string? name, string? email, string? password)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = password;
        IsActive = false;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public UserEntity(Guid id, string? name, string? email, string? password,bool isActive, DateTimeOffset createdAt,
        DateTimeOffset updatedAt)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        IsActive = isActive;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
}