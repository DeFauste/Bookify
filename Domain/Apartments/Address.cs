namespace Domain.Apartments;

/// <summary>
/// Адрес расположения бронируемой квартиры
/// </summary>
public record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);