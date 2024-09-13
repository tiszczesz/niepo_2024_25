using System;

namespace api_no_controller.Models;

public class MysqlBookRepo : IBooksRepo
{
    private ConfigurationManager configuration;

    public MysqlBookRepo(ConfigurationManager configuration)
    {
        this.configuration = configuration;
    }

    public void AddMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public void DeleteMovie(int? id)
    {
        throw new NotImplementedException();
    }

    public Movie? GetMovieById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Movie> GetMovies()
    {
        throw new NotImplementedException();
    }

    public void UpdateMovie(int? id, Movie movie)
    {
        throw new NotImplementedException();
    }
}
