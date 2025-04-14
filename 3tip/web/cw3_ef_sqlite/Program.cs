using cw3_ef_sqlite.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//dodanie serwisu do obsługi bazy danych
var connectiostring = builder.Configuration.GetConnectionString("sqlite");
//wstawienie SchoolContext do kontenera DI (Services)
//dzieki temu wszyscy kontrolery, które będą potrzebowały kontekstu bazy danych
//będą mogły go otrzymać jako parametr konstruktora
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlite(connectiostring));
    
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=Index}/{id?}");
//app.MapGet("/", () => "Hello World!");

app.Run();
