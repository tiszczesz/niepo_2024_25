using System;

namespace api_no_controller.Models;

public interface IBooksRepo
{
    public List<Movie> GetMovies();
    public Movie? GetMovieById(int id);
    public void AddMovie(Movie movie);
    public void DeleteMovie(int? id);
    public void UpdateMovie(int? id, Movie movie);

}
