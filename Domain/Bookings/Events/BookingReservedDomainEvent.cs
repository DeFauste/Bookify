using Domain.Abstractions;

namespace Domain.Bookings.Events;

/// <summary>
/// Событие резервирования апартаментов
/// </summary>
public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;