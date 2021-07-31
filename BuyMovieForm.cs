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
            
        }
    }
}
