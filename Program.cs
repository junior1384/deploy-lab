var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { status = "Healthy", version = "v1.0.0", message = "API 2 v1 - DEPLOY AUTOMÁTICO FUNCIONANDO!" }));
app.MapGet("/homolog-only", () => new
{
    status = "OK",
    environment = "HOMOLOG",
    version = "V2",
    message = "VERSÃO NOVA 2 - TESTE DE ROLLBACK"
});
app.Run();