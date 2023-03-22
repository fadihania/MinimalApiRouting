using Microsoft.AspNetCore.Mvc;

namespace MinimalApiRouting.Api;

public class CarsApi
{
    public void Register(WebApplication app)
    {
        // Cars API
        app.MapGet("/api/Cars", () => Data.cars); // Get All Cars
        app.MapGet("/api/Cars/{id}", ([FromRoute]string id) => // Get Car By Id
        {
            return Data.cars.FirstOrDefault(c => c.Id == id);
        });

        app.MapPost("/api/Cars", ([FromBody]Car newCar) => // Create Car
        {
            Data.cars.Add(newCar);
            return "Created!";
        });

        app.MapDelete("/api/Cars/{id}", ([FromRoute]string id) => // Delete Car
        {
            // Find the car
            var carToDelete = Data.cars.FirstOrDefault(c => c.Id == id);
            // Remove element
            Data.cars.Remove(carToDelete);

            return "Deleted";
        });

        app.MapPut("/api/Cars/{id}", ([FromRoute]string id, [FromBody]Car updatedCar) => // Update Car
        {
            var carIndex = Data.cars.FindIndex(c => c.Id == id);
            Data.cars[carIndex] = updatedCar;

            return "Updated!";
        });
    }
}
