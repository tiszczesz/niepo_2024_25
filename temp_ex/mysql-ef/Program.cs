using Microsoft.EntityFrameworkCore;
using mysql_ef.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//Add DbContext Mysql
var connectionString = builder.Configuration.GetConnectionString("MySqlConn");
builder.Services.AddDbContext<ShopDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Shop}/{action=List}/{id?}");

app.Run();
