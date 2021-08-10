using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public partial class GetMovieForm : Form
    {
        public GetMovieForm()
        {
            InitializeComponent();
        }

        private void movieInfoButton_Click(object sender, EventArgs e)
        {
            MovieContext context = new MovieContext();


            var infoMovie = context.Movies.Where(m => m.Title == movieListBox.Text).FirstOrDefault();
            MessageBox.Show("Title: " + infoMovie.Title + "\n" + "Release Year: " + infoMovie.releaseYear.ToString() + "\n" + "Rating: " + infoMovie.Rating + "\n" + "Genre: " + infoMovie.Genre + "\n" + "Runtime: " + infoMovie.Runtime.ToString() + "\n" + "Price: " + infoMovie.Price.ToString());
        }


        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetMovieForm_Load(object sender, EventArgs e)
        {

            MovieContext context = new MovieContext();

            //Had to set the title property in movie as a key since it doesnt have one.

            List<Movie> movieTitles =
                (from m in context.Movies
                 orderby m.Title
                 select m).ToList();


            movieListBox.DataSource = movieTitles;
            movieListBox.DisplayMember = "Title";

        }

    }
}
