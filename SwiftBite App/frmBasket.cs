using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SwiftBite
{
    public partial class frmBasket : Form
    {
        //Creates arrays to store the names of the labels
        public Label[] itemLabels;
        public Label[] priceLabels;

        public frmBasket()
        {
            InitializeComponent();
            this.ClientSize = new Size(1366, 768);
            lblCartNotificationText.Text = (Globals.McDonaldsitems.Count + Globals.Subwayitems.Count).ToString(); //Updates the cart badge to show the number of items "in the cart"
            LoadBasket();
        }
        

        public void CheckLoggedIn()
        {
            //Checks that the user is logged in
            if (!Globals.LoggedIn) 
            {
                //Opens the Login page if the user isn't logged in
                
                Globals.BasketClicked = true;
                MessageBox.Show("You must be logged in to view your basket.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblLogIn_Click(lblLogIn, EventArgs.Empty);
            }

            else if (Globals.LoggedIn)
            {
                //Opens the Basket form if the user is logged in

                frmBasket frmBasket = new frmBasket();
                frmBasket.Show();
            }
        }

        public void AddToArrays()
        {
            //Adds the names of the labels to the arrays
            itemLabels = new Label[]
            {
                lblItem1, lblItem2, lblItem3, lblItem4, lblItem5, lblItem6, lblItem7, lblItem8, lblItem9, lblItem10, lblItem11, lblItem12, lblItem13, lblItem14, lblItem15, lblItem16, lblItem17, lblItem18, lblItem19, lblItem20, lblItem21, lblItem22, lblItem23, lblItem24, lblItem25, lblItem26, lblItem27, lblItem28, lblItem29, lblItem30, lblItem31, lblItem32
            };

            priceLabels = new Label[]
            {
                lblItem1Price, lblItem2Price, lblItem3Price, lblItem4Price, lblItem5Price, lblItem6Price, lblItem7Price, lblItem8Price, lblItem9Price, lblItem10Price, lblItem11Price, lblItem12Price, lblItem13Price, lblItem14Price, lblItem15Price, lblItem16Price, lblItem17Price, lblItem18Price, lblItem19Price, lblItem20Price, lblItem21Price, lblItem22Price, lblItem23Price, lblItem24Price, lblItem25Price, lblItem26Price, lblItem27Price, lblItem28Price, lblItem29Price, lblItem30Price, lblItem31Price, lblItem32Price
            };
        }

        decimal DeliveryCost = 0;

        public void DeliveryCostCalc()
        {
            DeliveryCost = 0;

            if (Globals.McDonaldsitems.Count != 0)
            {
                DeliveryCost += 1.99m;
            }

            if (Globals.Subwayitems.Count != 0)
            {
                DeliveryCost += 1.49m;
            }

            lblDeliveryFeeValue.Text = DeliveryCost.ToString("C");
        }

        decimal TotalPrice = 0;

        public void LoadBasket()
        {
            AddToArrays();
            DeliveryCostCalc();

            TotalPrice = 0;

            int basketIndex = 0;

            //McDonald's
            foreach (var itemKey in Globals.McDonaldsitems)
            {
                if (basketIndex >= itemLabels.Length) break;

                itemLabels[basketIndex].Text = itemKey == "Mc Side Salad" ? "Side Salad" : itemKey;
                itemLabels[basketIndex].Visible = true;

                decimal price = Globals.McDonaldsPrices[itemKey];
                priceLabels[basketIndex].Text = price.ToString("C");
                priceLabels[basketIndex].Visible = true;

                TotalPrice += price;
                basketIndex++;
            }

            //Subway
            foreach (var itemKey in Globals.Subwayitems)
            {
                if (basketIndex >= itemLabels.Length) break;

                itemLabels[basketIndex].Text = itemKey;
                itemLabels[basketIndex].Visible = true;

                decimal price = Globals.SubwayPrices[itemKey];
                priceLabels[basketIndex].Text = price.ToString("C");
                priceLabels[basketIndex].Visible = true;

                TotalPrice += price;
                basketIndex++;
            }

            lblTotalValue.Text = (TotalPrice + DeliveryCost).ToString("C");
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Writes order information to Orders.csv

            try
            {
                using (StreamWriter writer = new StreamWriter("Orders.csv", append: true))
                {
                    //Joins all items into one string (for each restaurant)
                    string McDonaldsItems = string.Join(";", Globals.McDonaldsitems);
                    McDonaldsItems = $"\"{McDonaldsItems}\"";

                    string SubwayItems = string.Join(";", Globals.Subwayitems);
                    SubwayItems = $"\"{SubwayItems}\"";

                    writer.WriteLine($"{Globals.name},{Globals.username},{McDonaldsItems},{SubwayItems},{DeliveryCost}, {TotalPrice + DeliveryCost}");
                }

                MessageBox.Show("Order Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clears data
                Globals.McDonaldsitems.Clear();
                Globals.Subwayitems.Clear();

                for (int i = 0; i < itemLabels.Length; i++)
                {
                    itemLabels[i].Visible = false;
                    priceLabels[i].Visible = false;
                }

                //Opens the Home form
                frmHome frmHome = new frmHome();
                frmHome.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBasket_Click(object sender, EventArgs e)
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
