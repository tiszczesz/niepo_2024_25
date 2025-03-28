using System;
using Microsoft.Data.Sqlite;

namespace api_no_controller.Models;

public class MoviesRepo: IBooksRepo
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

    public Movie? GetMovieById(int id)
    {
         using var conn = new SqliteConnection(_connectionString);
        SqliteCommand cmd = conn.CreateCommand();
        cmd.CommandText = $"SELECT * FROM Movies WHERE Id = {id}";
        conn.Open();
        SqliteDataReader reader = cmd.ExecuteReader();
        if(!reader.HasRows) return null;
        reader.Read();
        var movie = new Movie{
            Id = reader.GetInt32(0),
            Title = reader.GetString(1),
            Director = reader.GetString(2),
            Year = reader.GetString(3)
        };
        conn.Close();
        return movie;
    }

    public void AddMovie(Movie movie)
    {
        using var conn = new SqliteConnection(_connectionString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText =
           "INSERT INTO Movies (Title, Director, Year) VALUES "
                +$" ('{movie.Title}', '{movie.Director}', '{movie.Year}')";
        conn.Open();
        command.ExecuteNonQuery();
        conn.Close();
    }

    public void DeleteMovie(int? id)
    {
        if(id==null) return;
        using var conn = new SqliteConnection(_connectionString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = $"DELETE FROM Movies WHERE Id = {id}";
        conn.Open();
        command.ExecuteNonQuery();
        conn.Close();
    }

    public void UpdateMovie(int? id, Movie movie)
    {
        using (var conn = new SqliteConnection(_connectionString)){
             SqliteCommand command = conn.CreateCommand();
             command.CommandText = $"UPDATE Movies SET Title = '{movie.Title}',"
                   +$" Director = '{movie.Director}', Year = '{movie.Year}' WHERE Id = {id}";
             conn.Open();
             command.ExecuteNonQuery();
             conn.Close();
        }       
    }
}
