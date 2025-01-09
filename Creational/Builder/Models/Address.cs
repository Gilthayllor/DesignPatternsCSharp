namespace Builder.Models;

public class Address
{
    public string City { get; set; } = string.Empty;
    public string Street { get; set ; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    
    public override string ToString()
    {
        return $"City: {City}, Street: {Street}, ZipCode: {ZipCode}, State: {State}, Country: {Country}";
    }
}