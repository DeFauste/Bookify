namespace Domain.Users;

public interface IUserRepository
{
    Task<User?> GetUserAsync(Guid userId, CancellationToken cancellationToken = default);
    
    void Add(User user);
}