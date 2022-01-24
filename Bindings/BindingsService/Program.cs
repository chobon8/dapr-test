var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/myevent", ([Microsoft.AspNetCore.Mvc.FromBody] string @event) => Console.WriteLine($"Hello {@event}!"));

app.Run();