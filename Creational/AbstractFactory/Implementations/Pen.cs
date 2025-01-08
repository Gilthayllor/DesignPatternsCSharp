using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations;

public class BlackPen : IPen
{
    public string InkColor => "black";

    public void Write(string? text)
    {
        Console.WriteLine($"Writing '{text}' with a {InkColor} pen.");
    }
}

public class YellowPen : IPen
{
    public string InkColor => "yellow";

    public void Write(string? text)
    {
        Console.WriteLine($"Writing '{text}' with a {InkColor} pen.");
    }
}