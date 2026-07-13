namespace Web.Controllers.Apartments;

/// <summary>
/// Запрос на бронирование апартаментов
/// </summary>
public sealed record ReserveBookingRequest(
    Guid ApartmentId,
    Guid UserId,
    DateOnly StartDate,
    DateOnly EndDate);