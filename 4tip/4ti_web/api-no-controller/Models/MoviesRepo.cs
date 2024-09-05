using System;
using Microsoft.Data.Sqlite;

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
        var movies = new List<Movie>();
        using var conn = new SqliteConnection(_connectionString);
        SqliteCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Movies";
        conn.Open();
        SqliteDataReader reader = cmd.ExecuteReader();
        while (reader.Read()){
            movies.Add(new Movie{
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Director = reader.GetString(2),
                Year = reader.GetString(3)
            });
        }
        conn.Close();
        return movies;
    }
}
