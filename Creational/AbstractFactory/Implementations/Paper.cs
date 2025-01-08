using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations;

public class BlackPaper : IPaper
{
    public void WriteOn(string? text)
    {
        Console.WriteLine($"Writing '{text}' on a black paper.");
    }
}

public class YellowPaper : IPaper
{
    public void WriteOn(string? text)
    {
        Console.WriteLine($"Writing '{text}' on a yellow paper.");
    }
}

