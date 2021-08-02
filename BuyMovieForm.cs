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
            PurchaseForm form = new PurchaseForm();
            form.Show();
        } 

        private void BuyMovieForm_Load(object sender, EventArgs e)
        {
           // moved to other method because putting it here doesn't work for some reason?
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuyMovieForm_Load_1(object sender, EventArgs e)
        {
            MovieContext context = new MovieContext();

            //Had to set the title property in movie as a key since it doesnt have one.

            List<Movie> movieTitles =
                (from m in context.Movies
                 orderby m.Title
                 select m).ToList();



            movieListBox.DataSource = movieTitles;
            movieListBox.DisplayMember = "Title";
            // for some reason this works but putting this in buyMovieForm_Load doesn't work.
           

        }
    }
}
