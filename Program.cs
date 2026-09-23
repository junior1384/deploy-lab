var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { status = "Healthy", version = "v1.0.0", message = "API 2 v1 - DEPLOY AUTOMÁTICO FUNCIONANDO!" }));
app.MapGet("/homolog-only", () => new
{
    status = "OK",
    environment = "HOMOLOG",
    message = "Esta funcionalidade existe somente na branch develop!"
});
app.Run();