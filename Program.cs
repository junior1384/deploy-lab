var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { status = "Healthy", version = "v1.0.0", message = "API v1 no ar!" }));

app.Run();