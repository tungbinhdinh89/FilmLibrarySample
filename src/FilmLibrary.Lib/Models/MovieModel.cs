using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Lib.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Director { get; set; } = null!;
        public int IMDBRating { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
