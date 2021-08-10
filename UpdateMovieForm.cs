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
    public partial class UpdateMovieForm : Form
    {
        public MovieContext context = new MovieContext();
        public UpdateMovieForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //Had to set the title property in movie as a key since it doesnt have one.

            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var selectedMovie = context.Movies.Where(m => m.Title == movieListBox.Text).FirstOrDefault();

            
            if(releaseYearBox == null)
            {
                selectedMovie.releaseYear = selectedMovie.releaseYear;
            }
            else
            {

                selectedMovie.releaseYear = int.Parse(releaseYearBox.Text);
            }
            if(ratingBox.Text == null)
            {
                selectedMovie.Rating = selectedMovie.Rating;
            }
            else
            {
                selectedMovie.Rating = ratingBox.Text;
            }
            if(genreBox.Text == null)
            {
                selectedMovie.Genre = selectedMovie.Genre;
            }
            else
            {
                selectedMovie.Genre = genreBox.Text;
            }
            if(runtimeBox == null)
            {
                selectedMovie.Runtime = selectedMovie.Runtime;
            }
            else
            {
                selectedMovie.Runtime = int.Parse(runtimeBox.Text);
            }
            if(priceBox == null)
            {
                selectedMovie.Price = selectedMovie.Price;
            }
            else
            {
                decimal.TryParse(priceBox.Text, out decimal result);
                selectedMovie.Price = result;
                 
            }
            MessageBox.Show(selectedMovie.Title + " was updated successfully");
            context.SaveChanges();

            
            this.Close();

        }

        private void UpdateMovieForm_Load(object sender, EventArgs e)
        {
            List<Movie> movieTitles =
                (from m in context.Movies
                 orderby m.Title
                 select m).ToList();


            movieListBox.DataSource = movieTitles;
            movieListBox.DisplayMember = "Title";
        }
    }
}
