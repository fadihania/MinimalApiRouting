namespace MinimalApiRouting;

public class Data
{
    public static List<Car> cars = new()
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
}
