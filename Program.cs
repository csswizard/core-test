var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "this is from core-test automatic build when pushing to dev!");
 
app.Run();
