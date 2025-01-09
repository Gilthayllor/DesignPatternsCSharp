using Builder.Models;

namespace Builder.Abstractions;

public class CarBuilder : ICarBuilder
{
    private readonly Car _car = new();

    public void SetColor(string color)
    {
        _car.Color = color;
    }

    public void SetBrand(string brand)
    {
        _car.Brand = brand;
    }

    public void SetModel(string model)
    {
        _car.Model = model;
    }

    public void SetDoors(int doors)
    {
        _car.Doors = doors;
    }

    public Car GetCar()
    {
        return _car;
    }
}