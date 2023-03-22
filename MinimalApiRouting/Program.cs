using MinimalApiRouting;
var builder = WebApplication.CreateBuilder(args);
// Services
// 👉
var app = builder.Build();
// Cars list
var cars = new List<Car>
{
    new Car
    {
        Id = "111", Brand = "VW", Model = "Golf",
        ProductionYear = 2015, Color = "White"
    },
    new Car
    {
        Id = "222", Brand = "KIA", Model = "Soul",
        ProductionYear = 2023, Color = "Silver"
    },
    new Car
    {
        Id = "333", Brand = "Skoda", Model = "Octavia",
        ProductionYear = 2020, Color = "Black"
    },
};
// Middlewares
// 👉
app.MapGet("/", () => "Car Manager");
// Car API
app.MapGet("/api/Cars", () => cars); // Get All Cars
app.MapGet("/api/Cars/{id}", (string id) => // Get Car By Id
{
    return cars.FirstOrDefault(c => c.Id == id);
});
app.MapPost("/api/Cars", (Car newCar) => // Create Car
{
    cars.Add(newCar);
    return "Created!";
});

app.Run();