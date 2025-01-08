namespace AbstractFactory.Interfaces;

public interface IStationeryFactory
{
    IPen CreatePen();
    IPaper CreatePaper();
}