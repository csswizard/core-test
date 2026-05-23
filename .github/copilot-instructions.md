# Copilot Instructions

## Project Overview

Minimal ASP.NET Core 9 web application using the minimal API pattern (no controllers). Targets `net9.0` with nullable reference types and implicit usings enabled.

## Build & Run

```bash
# Run the application
dotnet run

# Run with a specific profile (http or https)
dotnet run --launch-profile https
```

- HTTP: `http://localhost:5144`
- HTTPS: `https://localhost:7269`

## Architecture

`Program.cs` is the single entry point using top-level statements and the minimal API pattern:

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "...");

app.Run();
```

All routes are registered directly on `app` using `app.Map*` methods. There are no controllers, no service layers, and no middleware configured beyond defaults.

## CI/CD

Azure Pipelines (`azure-pipelines.yml`) triggers on pushes to `main`, targeting `ubuntu-latest`.

## Key Conventions

- **Nullable enabled**: All reference types require explicit nullability annotations (`string?` vs `string`).
- **Implicit usings**: Common namespaces (`System`, `Microsoft.AspNetCore.*`, etc.) are available without explicit `using` statements.
- **Minimal API style**: Prefer `app.MapGet/MapPost/...` route handlers over MVC controllers when adding endpoints.
