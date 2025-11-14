using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftBite
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.ClientSize = new Size(1366, 768);
        }

        private void lblContinue_Click(object sender, EventArgs e)
        {
            //Opens the Restaurant Selection form

            frmRestaurantSelection frmRestaurantSelection = new frmRestaurantSelection();
            frmRestaurantSelection.Show();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        public void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Globals.HandleSearch(txtSearch.Text, this);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void lblContinue_Enter(object sender, EventArgs e)
        {

        }

        public void lblContinue_MouseEnter(object sender, EventArgs e)
        {
        }

        private void lblContinue_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
