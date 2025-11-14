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
    public partial class frmSubway : Form
    {
        public frmSubway()
        {
            InitializeComponent();
            this.ClientSize = new Size(1366, 768);
            lblCartNotificationText.Text = (Globals.McDonaldsitems.Count + Globals.Subwayitems.Count).ToString(); //Updates the cart badge to show the number of items "in the cart"
        }

        private void picStar_Click(object sender, EventArgs e)
        {

        }

        private void btnHoneyMustard_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            //Gets the item key from the Tag:
            string itemKey = btn.Tag as string;
            if (itemKey == null) return;

            if (!Globals.Subwayitems.Contains(itemKey)) //If the item has not yet been "added to cart"
            {
                Globals.Subwayitems.Add(itemKey); //Adds item to cart
                btn.BackgroundImage = Properties.Resources.Add_Item_TICK; //Changes the button's BackgroundImage to display a `✓`
            }

            else
            {
                Globals.Subwayitems.Remove(itemKey); //Removes item from cart
                btn.BackgroundImage = Properties.Resources.Add_Item_PLUS; //Changes the button's BackgroundImage to display a `+`
            }

            lblCartNotificationText.Text = (Globals.McDonaldsitems.Count + Globals.Subwayitems.Count).ToString(); //Updates the cart badge to show the number of items "in the cart"
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            //Opens the Home form

            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void picCartIcon_Click(object sender, EventArgs e)
        {
            //Opens the Basket form

            frmBasket frmBasket = new frmBasket();
            frmBasket.CheckLoggedIn();
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
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
    }
}
