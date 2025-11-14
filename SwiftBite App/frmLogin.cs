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
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            //Opens the Signup form

            frmSignup frmSignup = new frmSignup();
            frmSignup.Show();
            this.Hide();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Creates variables to store the information entered into the input fields
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            bool usernameFound = false;

            //Attempts to find the entered username and password combination entered by the user in the logins file
            try
            {
                using (StreamReader sr = new StreamReader("logins.csv"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Splits the line into individual sets of data
                        string[] credentials = line.Split(',');

                        if (credentials.Length != 4) continue; //Skip invalid lines - Each line should have 5 parts of information if created using the Signup page

                        //Only stores the username and password
                        string fileUsername = credentials[2].Trim();
                        string filePassword = credentials[3].Trim();

                        if (fileUsername == enteredUsername)
                        {
                            usernameFound = true;

                            if (filePassword == enteredPassword)
                            {
                                //Clears the text boxes
                                txtUsername.Clear();
                                txtPassword.Clear();

                                //Updates the global variables to store the info of the current user
                                Globals.name = credentials[0];
                                Globals.username = fileUsername;

                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Globals.LoggedIn = true;

                                if (Globals.BasketClicked)
                                {
                                    Globals.BasketClicked = false;

                                    //Opens the Basket form
                                    frmBasket frmBasket = new frmBasket();
                                    frmBasket.Show();
                                    this.Hide();
                                }

                                else if (!Globals.BasketClicked)
                                {
                                    //Opens the Restaurant Selection form

                                    frmRestaurantSelection frmRestaurantSelection = new frmRestaurantSelection();
                                    frmRestaurantSelection.Show();
                                    this.Hide();
                                }

                                return;
                            }
                            else
                            {
                                MessageBox.Show("Password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                if (!usernameFound)
                {
                    MessageBox.Show("Username doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Logins file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }
    }
}
