using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MovieDatabase
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            //creating database context to add movie object
            MovieContext context = new MovieContext();

            //making movie object and giving it it's properites
            Movie addedMovie = new Movie();
            addedMovie.Title = titleBox.Text;
            addedMovie.releaseYear = int.Parse(releaseYearBox.Text);
            addedMovie.Rating = ratingBox.Text;
            addedMovie.Genre = genreBox.Text;
            addedMovie.Runtime = int.Parse(runtimeBox.Text);
            addedMovie.Price = decimal.Parse(priceBox.Text);

            //adding movie object to database
            context.Movies.Add(addedMovie);
            context.SaveChanges();



            
            




        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
