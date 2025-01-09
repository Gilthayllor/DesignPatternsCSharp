using Builder.Models;

namespace Builder.Abstractions;

public class AddressBuilder
{
    private string _city = string.Empty;
    private string _street = string.Empty;
    private string _zipCode = string.Empty;
    private string _state = string.Empty;
    private string _country = string.Empty;
    
    public static AddressBuilder CreateBuilder() => new AddressBuilder();
    
    public AddressBuilder SetCity(string city)
    {
        _city = city;
        return this;
    }
    
    public AddressBuilder SetStreet(string street)
    {
        _street = street;
        return this;
    }
    
    public AddressBuilder SetZipCode(string zipCode)
    {
        _zipCode = zipCode;
        return this;
    }
    
    public AddressBuilder SetState(string state)
    {
        _state = state;
        return this;
    }
    
    public AddressBuilder SetCountry(string country)
    {
        _country = country;
        return this;
    }
    
    public Address Build()
    {
        return new Address
        {
            City = _city,
            Street = _street,
            ZipCode = _zipCode,
            State = _state,
            Country = _country
        };
    }
}