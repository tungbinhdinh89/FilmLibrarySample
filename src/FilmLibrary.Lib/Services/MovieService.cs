using FilmLibrary.Lib.Models;

namespace FilmLibrary.Lib.Services
{
    public interface IMovieService
    {
        Task<MovieModel[]> SearchMoviesAsync(string keyword);
    }

    public class MovieService : IMovieService
    {
        public Task<MovieModel[]> SearchMoviesAsync(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
