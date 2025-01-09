using Builder.Models;

namespace Builder.Abstractions;

public class CustomerBuilder
{
    private string _name = string.Empty;
    private string _email = string.Empty;
    private int _age = 0;
    private readonly AddressBuilder _addressBuilder = AddressBuilder.CreateBuilder();
    
    public static CustomerBuilder CreateBuilder() => new CustomerBuilder();
    
    public CustomerBuilder SetName(string name)
    {
        _name = name;
        return this;
    }
    
    public CustomerBuilder SetEmail(string email)
    {
        _email = email;
        return this;
    }
    
    public CustomerBuilder SetAge(int age)
    {
        _age = age;
        return this;
    }

    public CustomerBuilder WithAddress(Action<AddressBuilder> buildAction)
    {
        buildAction(_addressBuilder);
        return this;
    }
    
    public Customer Build()
    {
        return new Customer
        {
            Name = _name,
            Email = _email,
            Age = _age,
            Address = _addressBuilder.Build()
        };
    }
}