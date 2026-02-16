namespace Domain.Apartments;

/// <summary>
/// Интерфейс репозитория апартаментов
/// </summary>
public interface IApartmentRepository
{
    /// <summary>
    /// Получение апартаментов
    /// </summary>
    Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}