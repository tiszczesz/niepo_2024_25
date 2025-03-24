var builder = WebApplication.CreateBuilder(args);
//dodanie serwisu do obsługi bazy danych
var connectiostring = builder.Configuration.GetConnectionString("sqlite");

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=Index}/{id?}");
//app.MapGet("/", () => "Hello World!");

app.Run();
