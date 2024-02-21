namespace FilmLibrary.Lib.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string IMDBId { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public string Director { get; set; } = null!;

        public string Actors { get; set; } = null!;

        public string IMDBRating { get; set; } = null!;

        public DateTime ReleaseDate { get; set; }

    }
}
