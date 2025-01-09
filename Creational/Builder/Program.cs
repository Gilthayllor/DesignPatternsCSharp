using Builder.Abstractions;

// Uma instancia de um carro é criada e configurada com a ajuda de um builder
ICarBuilder builder = new CarBuilder();

builder.SetBrand("Toyota");
builder.SetColor("Red");
builder.SetModel("Corolla");
builder.SetDoors(4);
var car = builder.GetCar();

Console.WriteLine(car);

// Neste caso, uma instância de cliente é criada usando um Fluent Builder
var customer = CustomerBuilder.CreateBuilder()
    .SetName("Gilthayllor Sousa")
    .SetAge(26)
    .SetEmail("gilthayllor@outlook.com")
    .WithAddress(x =>
    {
        x.SetCity("São Paulo")
            .SetState("SP")
            .SetCountry("Brazil")
            .SetZipCode("05835-004")
            .SetStreet("Estrada de Itapecerica, 1528");
    })
    .Build();

Console.WriteLine(customer);