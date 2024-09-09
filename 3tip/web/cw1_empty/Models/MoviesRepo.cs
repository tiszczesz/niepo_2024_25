using System;
using Microsoft.Data.Sqlite;

namespace cw1_empty.Models;

public class MoviesRepo
{
    private string? _connectionString;
    public MoviesRepo(IConfiguration configuration){
        _connectionString = configuration.GetConnectionString("sqlite");
    }
   public  List<Movie> GetMovies(){
       List<Movie> movies = new List<Movie>();
       using (SqliteConnection conn = new SqliteConnection(_connectionString))
       {
            
       }
       return movies;
   }
}
