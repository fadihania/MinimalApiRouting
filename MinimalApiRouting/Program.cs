var builder = WebApplication.CreateBuilder(args);
// Services
// 👉

var app = builder.Build();
// Middlewares
// 👉

app.MapGet("/", () => "Car Manager");

// Car API
app.MapGet("/api/Cars", () => "Cars");

app.Run();