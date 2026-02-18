namespace Domain.Users;

/// <summary>
/// Интерфейс работы с пользователями
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Получение пользователя
    /// </summary>
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Добавить пользователя
    /// </summary>
    void Add(User user);
}