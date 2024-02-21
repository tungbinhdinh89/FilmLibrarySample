using FilmLibrary.Lib.Models;
using FilmLibrary.Lib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.App
{
    public partial class NewMovieForm : Form
    {
        private IImdbSearchService imdbSearchService = new ImdbSearchService();
        private IMovieService movieService = new MovieService();

        public NewMovieForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var movie = imdbSearchService.SearchMovieImdbAsync(txtIMDBSearch.Text);
        }

        private void ShowMovieDetail(MovieModel movie)
        {
            txtTitle.Text = movie.Title;
            txtReleaseDate.Text = movie.ReleaseDate.ToString("dd/MM/yyyy");
            txtGenre.Text = movie.Genre;
            txtDirector.Text = movie.Director;
            txtActors.Text = movie.Actors;
            rtxtDescription.Text = movie.Description;
            txtIMDBRating.Text = movie.IMDBRating;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //movieService.AddNewMovieAsync(movie);
        }
    }
}
