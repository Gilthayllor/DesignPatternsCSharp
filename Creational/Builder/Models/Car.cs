namespace Builder.Models;

public class Car
{
    public string Color { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Doors { get; set; } = 0;

    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, Color: {Color}, Doors: {Doors}";
    }
}