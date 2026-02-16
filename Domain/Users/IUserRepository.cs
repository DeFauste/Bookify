namespace Domain.Users;

/// <summary>
/// Интерфейс работы с пользователями
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Получение пользователя
    /// </summary>
    Task<User?> GetUserAsync(Guid userId, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Добавить пользователя
    /// </summary>
    void Add(User user);
}