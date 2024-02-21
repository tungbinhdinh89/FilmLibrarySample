using FilmLibrary.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Lib.Services
{
    public interface IImdbSearchService
    {
        Task<MovieModel> SearchMovieImdbAsync(string imdbId);
    }

    public class ImdbSearchService : IImdbSearchService
    {
        public Task<MovieModel> SearchMovieImdbAsync(string imdbId)
        {
            throw new NotImplementedException();
        }
    }
}
