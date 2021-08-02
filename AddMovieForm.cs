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
using System.Windows.Forms.Design;
using System.Text.RegularExpressions;

namespace MovieDatabase
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        public bool MovieNotEmpty()
        {
            //validation
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    var textbox = (TextBox)control;
                    if (String.IsNullOrWhiteSpace(textbox.Text))
                    {
                        MessageBox.Show("One or more fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textbox.Text = String.Empty;
                        return false;
                    }
                }
            }
            return true;
        }

        public bool ValidYear()
        {
            int year = 0;
            if (!int.TryParse(releaseYearBox.Text, out year))
            {
                ErrorProvider yearError = new ErrorProvider();
                yearError.SetError(releaseYearBox, "Invalid year. Enter a year. e.g. 1999");
                return false;
            }
            return true;
        }

        public bool ValidRunTime()
        {
            int runtime = 0;
            if (!int.TryParse(runtimeBox.Text, out runtime))
            {
                ErrorProvider runTimeError = new ErrorProvider();
                runTimeError.SetError(runtimeBox, "Invalid runtime. Enter a whole number.");
                return false;
            }
            return true;
        }

        public bool ValidPrice()
        {
            if (!decimal.TryParse(priceBox.Text, out decimal price))
            {
                ErrorProvider priceError = new ErrorProvider();
                priceError.SetError(priceBox, "Invalid price. Enter a decimal number. e.g. 29.99");
                return false;
            }
            return true;
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            //validation
            if (MovieNotEmpty() && ValidYear() && ValidPrice() && ValidRunTime())
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

                string title = titleBox.Text;


                DialogResult confirm = MessageBox.Show(title + " was added!");
            }
            

            
            




        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
