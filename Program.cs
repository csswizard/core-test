var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "this is from core-test!");

app.Run();
