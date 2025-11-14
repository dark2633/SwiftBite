using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftBite
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
            this.ClientSize = new Size(1366, 768);
            lblCartNotificationText.Text = (Globals.McDonaldsitems.Count + Globals.Subwayitems.Count).ToString(); //Updates the cart badge to show the number of items "in the cart"
        }

        private void btnPassShowHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '\0')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
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
        
        private bool usernameExists(string username)
        {
            //Checks if the entered username already exists and registered to an account

            bool usernameFound = false;
            
            using (StreamReader sr = new StreamReader("logins.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Splits the line into individual sets of data
                    string[] credentials = line.Split(',');

                    if (credentials.Length != 4) continue; //Skip invalid lines - Each line should have 5 parts of information if created using the Signup page

                    //Only stores the username
                    string fileUsername = credentials[2].Trim();

                    if (fileUsername == username)
                    {
                        usernameFound = true;
                    }
                }
            }

            return usernameFound;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Creates variables to store the information entered into the input fields
            string strName = txtName.Text;
            string strEmail = txtEmail.Text;
            string strUsername = txtUsername.Text;
            string strPassword = txtPassword.Text;

            //Checks if all input fields are filled out
            if (string.IsNullOrWhiteSpace(strName) || string.IsNullOrWhiteSpace(strEmail) || string.IsNullOrWhiteSpace(strUsername) || string.IsNullOrWhiteSpace(strPassword))
            {
                MessageBox.Show("All input fields must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!usernameExists(strUsername))
            {
                //Writes the information into the .csv file
                try
                {
                    using (StreamWriter writer = new StreamWriter("logins.csv", append: true))
                    {
                        writer.WriteLine($"{strName},{strEmail},{strUsername},{strPassword}");
                    }

                    MessageBox.Show("Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clears the text boxes
                    txtName.Clear();
                    txtEmail.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();

                    //Opens the Login form
                    lblLogIn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                txtUsername.Clear();
                MessageBox.Show("Username already exists.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
