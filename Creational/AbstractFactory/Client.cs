using AbstractFactory.Interfaces;

namespace AbstractFactory;

public class Client(IStationeryFactory stationeryFactory)
{
    private readonly IPaper _paper = stationeryFactory.CreatePaper();
    private readonly IPen _pen = stationeryFactory.CreatePen();
    
    public void UseStationery()
    {
        _paper.WriteOn("Hello, paper!");
        _pen.Write("Hello, pen!");
    }
}