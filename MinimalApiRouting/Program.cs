using MinimalApiRouting.Api;

var builder = WebApplication.CreateBuilder(args);
// Services
// 👉

var app = builder.Build();
// Middlewares
// 👉

app.MapGet("/", () => "Car Manager");
new CarsApi().Register(app);

app.Run();