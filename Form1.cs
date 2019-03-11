using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    

    public partial class Form1 : Form
    {
        double Coffee = 1.25;                           // Public doubles to arrange prices for each item individually.
        double Tea = 1.10;
        double cake = 1.25;
        double OrderTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Coffee ");
            priceLST.Items.Add(String.Format("{0:0.00}", Coffee));
            OrderTotal = OrderTotal + Coffee;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void cakeBtn_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Cake ");
            priceLST.Items.Add(String.Format("{0:0.00}", cake));
            OrderTotal = OrderTotal + cake;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void teaBtn_Click(object sender, EventArgs e)
        {
            salesLST.Items.Add("Tea ");
            priceLST.Items.Add(String.Format("{0:0.00}", Tea));
            OrderTotal = OrderTotal + Tea;
            totalTXT.Text = OrderTotal.ToString();
        }

        private void clearItemBtn_Click(object sender, EventArgs e)
        {
            if (this.priceLST.SelectedIndex >= 0)                                                  // Only run code if an item is selected.
            {
                double deductions = Convert.ToDouble(priceLST.GetItemText(priceLST.SelectedItem));   // Deducts selected item from the order list.

                OrderTotal = OrderTotal - deductions;                                              // Order total deducts cost of removed item price.

                totalTXT.Text = String.Format("{0:0.00}", OrderTotal).ToString();                  // Format then place the new orser total in the totalTXT box.

                this.salesLST.Items.RemoveAt(this.priceLST.SelectedIndex);                         // Removes items from the sales list.
                this.priceLST.Items.RemoveAt(this.priceLST.SelectedIndex);                         // Removes items from the price list.

            }

        }
    }
}
