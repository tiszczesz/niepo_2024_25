using api_no_controller.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBooksRepo, MoviesRepo>();//powiązanie interfejsu z klasą
//builder.Services.AddScoped<IBooksRepo, MysqlBookRepo>();
//cors
builder.Services.AddCors(options =>{
    options.AddPolicy("AllowAll", b => b.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});
//builder.Services.AddTransient<IBooksRepo, MoviesRepo>();
//builder.Services.AddTransient<IBooksRepo, MysqlBookRepo>();
//builder.Services.AddTransient<IBooksRepo, PostgresBookRepo>();

//var repo = new MoviesRepo(builder.Configuration);
//var repo = new MysqlBookRepo(builder.Configuration);
var app = builder.Build();

app.UseCors("AllowAll");

app.MapGet("/", () => "Hello World!");
app.MapGet("/movies", (IBooksRepo repo) => repo.GetMovies());
app.MapGet("/movies/{id}", (int? id,IBooksRepo repo) => {
    var result = repo.GetMovieById(id ?? 0);
    return result == null ? Results.NotFound() : Results.Ok(result);
});
app.MapPost("/movies", (Movie movie,IBooksRepo repo) => {
    repo.AddMovie(movie);
});
app.MapDelete("/movies/{id}", (int? id,IBooksRepo repo) => {
    repo.DeleteMovie(id ?? 0);
    return Results.Ok();
});
app.MapPut("/movies/{id}", (int? id, Movie movie,IBooksRepo repo) => {
    if(id == null) return Results.NotFound();
    repo.UpdateMovie(id, movie);
    return Results.Ok();
});
app.Run();
