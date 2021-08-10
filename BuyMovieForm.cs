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
    public partial class BuyMovieForm : Form
    {
        public BuyMovieForm()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            MovieContext context = new MovieContext();


            var deletedMovie = context.Movies.Where(m => m.Title == movieListBox.Text).FirstOrDefault();
            context.Movies.Remove(deletedMovie);
            context.SaveChanges();





            DialogResult confirm = MessageBox.Show("You have bought: " + movieListBox.Text+ "!");
            this.Close();





        } 

        private void BuyMovieForm_Load(object sender, EventArgs e)
        {
            //moved to BuyMovieForm_Load_1 because it doesn't work here but works there for some reason?
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuyMovieForm_Load_1(object sender, EventArgs e)
        {
            movieListBox.DataSource = null; 
            MovieContext context = new MovieContext();

            //Had to set the title property in movie as a key since it doesnt have one.

            List<Movie> movieTitles =
                (from m in context.Movies
                 orderby m.Title
                 select m).ToList();

            movieListBox.DataSource = movieTitles;

            movieListBox.DisplayMember = "Title";
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Maybe next time");
            this.Close();
        }
    }
}
