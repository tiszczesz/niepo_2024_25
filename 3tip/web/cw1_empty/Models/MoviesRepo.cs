using System;
using Microsoft.Data.Sqlite;

namespace cw1_empty.Models;

public class MoviesRepo
{
    private string? _connectionString;
    public MoviesRepo(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlite");
    }
    public List<Movie> GetMovies()
    {
        List<Movie> movies = new List<Movie>();
        using (SqliteConnection conn = new SqliteConnection(_connectionString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM movies";
            conn.Open();
            SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                movies.Add(new Movie
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Director = reader.GetString(2),
                    Year = reader.GetInt32(3)
                });
            }
            conn.Close();
        } // end using
        return movies;
    }

    public void AddMovie(Movie movie)
    {
        using SqliteConnection conn = new SqliteConnection(_connectionString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = "INSERT INTO movies (title, director, year) VALUES "
              +" (@title, @director, @year)"; //zabezpieczenie przed sql injection przez użycie parametrów
        command.Parameters.AddWithValue("@title", movie.Title);
        command.Parameters.AddWithValue("@director", movie.Director);
        command.Parameters.AddWithValue("@year", movie.Year);
        //  command.CommandText = "INSERT INTO movies (title, director, year) VALUES "
        //       +$" ('{movie.Title}', '{movie.Director}', {movie.Year})"; //bez zabezpieczenia
        conn.Open();
        command.ExecuteNonQuery();
        conn.Close();
    }
}
