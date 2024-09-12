using api_no_controller.Models;

var builder = WebApplication.CreateBuilder(args);

//cors
builder.Services.AddCors(options =>{
    options.AddPolicy("AllowAll", b => b.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

var repo = new MoviesRepo(builder.Configuration);
var app = builder.Build();

app.UseCors("AllowAll");

app.MapGet("/", () => "Hello World!");
app.MapGet("/movies", () => repo.GetMovies());
app.MapGet("/movies/{id}", (int? id) => {
    var result = repo.GetMovieById(id ?? 0);
    return result == null ? Results.NotFound() : Results.Ok(result);
});
app.MapPost("/movies", (Movie movie) => {
    repo.AddMovie(movie);
});
app.MapDelete("/movies/{id}", (int? id) => {
    repo.DeleteMovie(id ?? 0);
    return Results.Ok();
});
app.MapPut("/movies/{id}", (int? id, Movie movie) => {
    if(id == null) return Results.NotFound();
    repo.UpdateMovie(id, movie);
    return Results.Ok();
});
app.Run();
