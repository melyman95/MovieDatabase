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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            AddMovieForm form = new AddMovieForm();
            form.Show();
        }

        private void getMovieButton_Click(object sender, EventArgs e)
        {
            GetMovieForm form = new GetMovieForm();
            form.Show();
        }

        private void buyMovieButton_Click(object sender, EventArgs e)
        {
            BuyMovieForm form = new BuyMovieForm();
            form.Show();
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            UpdateMovieForm form = new UpdateMovieForm();
            form.Show();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
