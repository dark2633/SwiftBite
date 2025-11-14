using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftBite
{
    public partial class frmRestaurantSelection : Form
    {
        public frmRestaurantSelection()
        {
            InitializeComponent();
            this.ClientSize = new Size(1366, 768);
            lblCartNotificationText.Text = (Globals.McDonaldsitems.Count + Globals.Subwayitems.Count).ToString(); //Updates the cart badge to show the number of items "in the cart"
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            //Opens the Home form

            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void pnlMcDonalds_Click(object sender, EventArgs e)
        {
            //Opens the McDonald's form

            frmMcDonalds frmMcDonalds = new frmMcDonalds();
            frmMcDonalds.Show();
            this.Hide();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            //Opens the Login form

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Opens the Signup form

            frmSignup frmSignup = new frmSignup();
            frmSignup.Show();
            this.Hide();
        }

        private void pnlMcDonalds_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCartIcon_Click(object sender, EventArgs e)
        {
            frmBasket frmBasket = new frmBasket();
            frmBasket.CheckLoggedIn();
            this.Hide();
        }

        private void pnlSubway_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSubway_Click(object sender, EventArgs e)
        {
            //Opens the Subway form

            frmSubway frmSubway = new frmSubway();
            frmSubway.Show();
            this.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Globals.HandleSearch(txtSearch.Text, this);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
