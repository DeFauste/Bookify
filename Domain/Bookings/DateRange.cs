namespace Domain.Bookings;

public record DateRange
{
    private DateRange() { }
    public DateOnly Start { get; init; }
    public DateOnly End { get; init; }

    public int LengthInDay => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ArgumentOutOfRangeException(nameof(start), "Start date must be before end date");
        }

        return new DateRange { Start = start, End = end };
    }
}