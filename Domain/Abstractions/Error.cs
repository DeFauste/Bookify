namespace Domain.Abstractions;

public record Error(string Codo, string Name)
{
    public static Error None = new (string.Empty, string.Empty);
    
    public static Error NullValue = new ("Error.NullValue", "Null value was provided");
}