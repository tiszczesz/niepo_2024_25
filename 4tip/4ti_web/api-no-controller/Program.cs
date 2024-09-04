using api_no_controller.Models;

var builder = WebApplication.CreateBuilder(args);
var repo = new MoviesRepo(builder.Configuration);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/movies", () => repo.GetMovies());

//brak nuget package sqlite
app.Run();
