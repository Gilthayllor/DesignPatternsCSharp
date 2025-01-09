namespace Builder.Models;

public class Customer
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Age { get; set; }
    public Address Address { get; set; } = new();

    public override string ToString()
    {
        return $"Name: {Name}, Email: {Email}, Age: {Age}, \nAddress: {Address}";
    }
}