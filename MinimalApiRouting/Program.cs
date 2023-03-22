var builder = WebApplication.CreateBuilder(args);
// Services
// 👉

var app = builder.Build();
// Middlewares
// 👉

app.MapGet("/", () => "Car Manager");

app.Run();
