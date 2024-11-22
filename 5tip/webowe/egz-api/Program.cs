using egz_api.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(
            op => op.AddPolicy(
                "my", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    )
    );
var app = builder.Build();
app.UseCors("my");
string? connString = builder.Configuration.GetConnectionString("sqlite");
ProductsRepo repo = new ProductsRepo(connString);

app.MapGet("/", () => "Hello World!");
app.MapGet("/products", () => repo.GetProducts());

app.Run();
