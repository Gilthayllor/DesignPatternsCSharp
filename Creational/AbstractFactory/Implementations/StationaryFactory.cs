using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations;

public class BlackStationaryFactory : IStationeryFactory
{
    public IPen CreatePen()
    {
        return new BlackPen();
    }

    public IPaper CreatePaper()
    {
        return new BlackPaper();
    }
}

public class YellowStationaryFactory : IStationeryFactory
{
    public IPen CreatePen()
    {
        return new YellowPen();
    }

    public IPaper CreatePaper()
    {
        return new YellowPaper();
    }
}