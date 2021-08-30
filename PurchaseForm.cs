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

        private void orderButton_Click(object sender, EventArgs e)
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


            if (ValidTitle() == true && ValidShippingFirstName() == true && ValidShippingLastName() == true
                && IsCreditCardInfoValid(cardnumberBox.Text, expBox.Text, cvvBox.Text) == true
                && ValidShippingAddress() == true && ValidPhoneNumber(phoneNumberBox.Text) == true
                && ValidBillingAddress() == true)
            {
                context.Orders.Add(addedOrder);

                // Delete movie and save changes
                context.Movies.Remove(selectedMovie);
                context.SaveChanges();

                DialogResult confirm = MessageBox.Show("You Bought " + selectedMovie.Title + "!");
                this.Close();
            }
        }

        private bool ValidTitle()
        {
            ErrorProvider error = new ErrorProvider();
            bool valid = true;
            if (movieListBox.Text == "")
            {
                error.SetError(movieListBox, "Please enter a title.");
                valid = false;
            }
            else
            {
                error.SetError(movieListBox, "");
            }
            return valid;
        }

        private bool ValidShippingFirstName()
        {
            ErrorProvider error = new ErrorProvider();
            bool valid = true;
            if (firstNameBox.Text == "")
            {
                error.SetError(firstNameBox, "Please enter a first name.");
                valid = false;
            }
            else
            {
                error.SetError(firstNameBox, "");
            }
            return valid;
        }

        private bool ValidShippingLastName()
        {
            ErrorProvider error = new ErrorProvider();
            bool valid = true;
            if (lastNameBox.Text == "")
            {
                error.SetError(lastNameBox, "Please enter a last name.");
                valid = false;
            }
            else
            {
                error.SetError(lastNameBox, "");
            }
            return valid;
        }

        public static bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)
        {
            var cardCheck = new Regex(@"^(1298|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy            
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1])) // <3 - 6>
                return false; // ^ check date format is valid as "MM/yyyy"

            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }

        private bool ValidShippingAddress()
        {
            ErrorProvider error = new ErrorProvider();
            bool valid = true;
            if (shippingAddressBox.Text == "")
            {
                error.SetError(shippingAddressBox, "Please enter a shipping address.");
                valid = false;
            }
            else
            {
                error.SetError(shippingAddressBox, "");
            }
            return valid;
        }

        private bool ValidPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }

        private bool ValidBillingAddress()
        {
            ErrorProvider error = new ErrorProvider();
            bool valid = true;
            if (billingAddressBox.Text == "")
            {
                error.SetError(billingAddressBox, "Please enter a shipping address.");
                valid = false;
            }
            else
            {
                error.SetError(billingAddressBox, "");
            }
            return valid;
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
