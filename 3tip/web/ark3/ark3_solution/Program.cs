var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Notices}/{action=List}/{id?}");

// app.MapGet("/", () => "Hello World!");

app.Run();
