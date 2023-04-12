using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Code for the calculate tip button
        private void CalcTip_Button_Click(object sender, EventArgs e)
        {
            int numOfItems; // User's input
            int[] discountRangeLowLimits = { 1, 13, 50, 100, 200 };
            double[] discounts = { 0, 0.10, 0.14, 0.18, 0.20 };
            bool found = false;
            double customerDiscount = 0; //Assume no discount for bad input

            Write("Enter number of items purchased: ");
            numOfItems = int.Parse(ReadLine());

            int index = discountRangeLowLimits.Length - 1; // Start from end
                                                           // since lower limits
            while (index >= 0 && !found)
            {
                if (numOfItems >= discountRangeLowLimits[index])
                    found = true;
                else
                    --index;
            }

            if (found)
                customerDiscount = discounts[index];

            WriteLine($"Discount = {customerDiscount:p}");

        }
    }
}
