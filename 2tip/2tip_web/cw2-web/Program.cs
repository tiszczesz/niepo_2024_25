var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();


var app = builder.Build();
//dodanie middleware obsługa plików statycznych
app.UseStaticFiles();
string message = "<h1>Hello World!</h1>";
// app.MapGet("/", () => "ala ma kota");
// app.MapGet("/inna", () => "inna ala ma kota");
// app.MapGet("/message", () => message);
app.MapRazorPages();
//w katalogu Pages tworzymy plik Index.cshtml

app.Run();
