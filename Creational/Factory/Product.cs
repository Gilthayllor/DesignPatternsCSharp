namespace Factory;

public record ProductA : IProduct
{
    public string GetName() => "Product A";
}

public record ProductB : IProduct
{
    public string GetName() => "Product B";
}