namespace AbstractFactory.Interfaces;

public interface IPen
{
    string InkColor { get; }
    void Write(string? text);
}