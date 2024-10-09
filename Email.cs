
//https://medium.com/@gustavorestani/c-implicit-and-explicit-operators-a-comprehensive-guide-5e6972cc8671
using static System.Text.RegularExpressions.Regex;

public record EMail
{
    private const string emailPattern =
        @"^[A-Za-z0-9._+\-\']+@[A-Za-z0-9.\-]+\.[A-Za-z]{2,}$";

    public string Value { get; }

    private EMail(string value) => Value = value;

    public static explicit operator EMail(string? value)
    {
        if (string.IsNullOrEmpty(value))
            ArgumentException.ThrowIfNullOrEmpty(value);

        if (IsMatch(value, emailPattern) == false)
            throw new Exception($"'{value}' is an invalid EMail.");

        return new(value);
    }

    public static implicit operator string?(EMail email) 
        => email.Value;

    public override string ToString() 
        => Value;
}