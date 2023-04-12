// Grading ID: J3408
// Lab 7
// 11/07/2019
// CIS 199-01
// This program calculates present value from future value, annual interest rate, and amount of years which is calculated 
// in the CalcPresentValue method and set back to calc_btton by three parameters to the presentvalue.

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

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_button_Click(object sender, EventArgs e)
        {
            double futurevalue;                 // futurevalue
            double annualinterestrate;          // annual interes rate
            int years;                          // number of years
            double presentvalue;                // present value

            double.TryParse(futurevalue_txt.Text, out futurevalue);                 // From futurevalue_txt To futurevalue
            double.TryParse(interestrate_txt.Text, out annualinterestrate);         // From interestrate_txt.Text To annualinterestrate
            int.TryParse(year_txt.Text, out years);                                 // From year_txt.Text To years

            CalcPresentValue(futurevalue, annualinterestrate, years);               // sents three values to the CalcPresentValue()

            presentvalue = CalcPresentValue(futurevalue, annualinterestrate, years);    // values from CalcPresentValue() to presentvalue
            presentvalue_label.Text = $"{presentvalue:c}";                              // sends presentvalue to label
        }

        // Precondition: No Chars & Negative Numbers
        // Postcondition: The three variables are calculated by the formula and returns the value to double presentvalue
        public static double CalcPresentValue(double value, double rate, int year)     
        {
            double sum;                                     // value (total)

            sum = value / Math.Pow((1 + rate), year);       // present value formula

            return sum;                                     // returns the total back to calc_button_Click()
        }
    }
}
