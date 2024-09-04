using System;

namespace api_no_controller.Models;

public class MoviesRepo
{
    private readonly string? _connectionString;
    public MoviesRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Sqlite");
    }

    public List<Movie> GetMovies()
    {
        throw new NotImplementedException();
    }
}
