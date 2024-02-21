using FilmLibrary.Lib.Models;

namespace FilmLibrary.Lib.Services
{
    public interface IMovieService
    {
        Task<MovieModel[]> SearchMoviesAsync(string? keyword = null);
    }

    public class MovieService : IMovieService
    {
        public Task<MovieModel[]> SearchMoviesAsync(string? keyword = null)
        {
            throw new NotImplementedException();
        }
    }
}
