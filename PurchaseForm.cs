using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        // Regular expression used to validate a phone number.  
        public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (NoEmptyFields())
            {
                if (IsPhoneNumber(phoneNumberBox.Text) && isNumber(cvvBox.Text))
                {
                    MovieContext context = new MovieContext();
                    // Get selected Movie
                    var selectedMovie = context.Movies.Where(m => m.Title == movieListBox.Text).FirstOrDefault();
                    // Add Order object
                    Order addedOrder = new Order();
                    addedOrder.MovieTitle = movieListBox.Text;
                    addedOrder.ShippingName = firstNameBox.Text + " " + lastNameBox.Text;
                    addedOrder.CardNumber = cardnumberBox.Text;
                    addedOrder.Cvv = int.Parse(cvvBox.Text);
                    addedOrder.ExpDate = expBox.Text;
                    addedOrder.BillingAddress = billingAddressBox.Text;
                    addedOrder.PhoneNumber = phoneNumberBox.Text;
                    addedOrder.ShippingAddress = shippingAddressBox.Text;

                    context.Orders.Add(addedOrder);

                    // Delete movie and save changes
                    context.Movies.Remove(selectedMovie);
                    context.SaveChanges();

                    DialogResult confirm = MessageBox.Show("You Bought " + selectedMovie.Title + "!");
                    this.Close();
                }
                else if (!IsPhoneNumber(phoneNumberBox.Text) || !isNumber(cvvBox.Text)) 
                {
                    MessageBox.Show("Your phone number or CVV are invalid.", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool NoEmptyFields()
        {
            foreach(var control in Controls)
            {
                if (control is TextBox)
                {
                    var textbox = (TextBox)control;
                    if (String.IsNullOrWhiteSpace(textbox.Text)) {
                        MessageBox.Show("One or more fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textbox.Text = String.Empty;
                        return false;
                    }
                }
            }
            return true;
        }

        public bool isNumber(string s) 
        {
            return s.All(char.IsDigit);
        }

        public static bool IsPhoneNumber(string num) 
        {
            return Regex.IsMatch(num, motif);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Maybe next time");
            this.Close();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
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
    }
}
