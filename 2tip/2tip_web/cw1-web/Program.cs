var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();//dodane obsluga plikow statycznych
app.MapGet("/", () => "Hello World!");
app.MapGet("2tip", () => "Hello 2tip!");
app.MapGet("piatek", () => "za chwile bedzie weekend!");

app.Run();
