using Domain.Abstractions;
using Domain.Shared;

namespace Domain.Apartments;

public sealed class Apartment : Entity
{
    private Apartment() : base(default)
    {
        Name = default!;
        Descriptions = default!;
        Address = default!;
        Price = default!;
        CleaningFee = default!;
    }
    public Apartment(Guid id,
        Name name,
        Description descriptions,
        Address address,
        Money price,
        Money cleaningFee) : base(id)
    {
        Name = name;
        Descriptions = descriptions;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
    }

    /// <summary>
    /// Наименование апартаментов
    /// </summary>
    public Name Name { get; private set; }

    /// <summary>
    /// Описание апартаментов
    /// </summary>
    public Description Descriptions { get; private set; }

    /// <summary>
    /// Физический адрес
    /// </summary>
    public Address Address { get; private set; }

    /// <summary>
    /// Стоимость бронирования
    /// </summary>
    public Money Price { get; private set; }

    /// <summary>
    /// Стоимость уборки
    /// </summary>
    public Money CleaningFee { get; private set; }

    /// <summary>
    /// Последний заказанный на сайте
    /// </summary>
    public DateTime? LastBookedOnUtc { get; internal set; }

    /// <summary>
    /// Услуги
    /// </summary>
    public List<Amenity> Amenities { get; private set; } = new();
}