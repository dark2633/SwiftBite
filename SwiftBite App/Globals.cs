using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftBite
{
    internal class Globals
    {
        //McDonald's
        public static List<string> McDonaldsitems = new List<string>();
        public static readonly Dictionary<string, decimal> McDonaldsPrices = new Dictionary<string, decimal>
        {
            //Burgers
            ["Philly Cheese Stack"] = 6.49m,
            ["McCrispy® BBQ Smokeh..."] = 6.79m,
            ["McSpicy®"] = 5.79m,
            ["McPlant®"] = 5.49m,
            ["Big Mac®"] = 5.49m,
            ["McCrispy®"] = 5.99m,

            //Fries & Sides
            ["Large Fries"] = 2.89m,
            ["Medium Fries"] = 2.39m,
            ["Small Fries"] = 1.69m,
            ["Mc Side Salad"] = 1.09m,
            ["Apple Slices"] = 0.89m,

            //Drinks
            ["Flat White"] = 2.29m,
            ["Latte"] = 2.29m,
            ["Cappuccino"] = 2.29m,
            ["Coca-Cola® Zero"] = 2.19m,
            ["Nestle® PureLife®"] = 2.29m
        };

        //Subway
        public static List<string> Subwayitems = new List<string>();
        public static readonly Dictionary<string, decimal> SubwayPrices = new Dictionary<string, decimal>
        {
            //Subs
            ["Honey Mustard BBQ"] = 7.39m,
            ["Mexicana Beef Crunch"] = 6.49m,
            ["Furious Chicken"] = 7.39m,
            ["Garlic Cheese Steak"] = 7.39m,
            ["Big Breakwich"] = 7.39m,
            ["Tex Mexan"] = 6.79m,

            //Sides
            ["Waffle Fries"] = 2.39m,
            ["Chipotle Cheesy Bites"] = 2.89m,
            ["Cheesy Garlic Slice"] = 1.29m,
            ["Side Salad"] = 1.99m,
            ["Meatballs"] = 2.59m,

            //Drinks
            ["Costa Latte"] = 2.89m,
            ["Coca-Cola Zero"] = 2.59m,
            ["Dr Pepper"] = 2.59m,
            ["Princess Gate Still Water"] = 2.19m
        };

        //User Info
        public static string name;
        public static string username;

        //Logic for handling search
        public static void HandleSearch(string searchTerm, Form currentForm)
        {
            switch (searchTerm.Trim().ToLower())
            {
                case "mcdonald's":
                    frmMcDonalds frmMcDonalds = new frmMcDonalds();
                    frmMcDonalds.Show();
                    currentForm.Hide();
                    break;

                case "subway":
                    frmSubway frmSubway = new frmSubway();
                    frmSubway.Show();
                    currentForm.Hide();
                    break;

                default:
                    MessageBox.Show("Restaurant not found.\n\nPlease select from the following:\nMcDonald's\nSubway",
                        "Restaurant Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        //Other
        public static bool LoggedIn = false;
        public static bool BasketClicked = false;
    }
}
