var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "this is from core-test automatic build version 2!");
 
app.Run();
