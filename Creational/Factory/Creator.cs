namespace Factory;

public abstract class Creator
{
    public abstract IProduct Create();
}

public class ConcreteCreatorA : Creator
{
    public override IProduct Create() => new ProductA();
}

public class ConcreteCreatorB : Creator
{
    public override IProduct Create() => new ProductB();
}