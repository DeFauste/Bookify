namespace Domain.Apartments;

/// <summary>
/// Адрес расположения
/// </summary>
public record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);