using Builder.Models;

namespace Builder.Abstractions;

public interface ICarBuilder
{
    void SetColor(string color);
    void SetBrand(string brand);
    void SetModel(string model);
    void SetDoors(int doors);
    Car GetCar();
}