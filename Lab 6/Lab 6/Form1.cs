// Grading ID: J3408
// Lab 6
// 10/27/2019
// CIS 199-01
// This solution assigns grades based on a student's amount of words typed

using System;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_button_Click(object sender, EventArgs e)
        {
            int[] wordamount = { 0, 16, 31, 51, 76 };                       // lower limit arrary in int
            char[] grades = { 'F', 'D', 'C', 'B', 'A' };                    // parallel arrary containing grade letters in char

            int userinput;                                                  // variable for user input
            bool found = false;                                             // boolean variable set to false
            char lettergrade;                                               // output char variable

            int.TryParse(wordstyped_txtbox.Text, out userinput);            // tryparse input from textbox to user variable

            int index = wordamount.Length - 1;                              // starting in lower limits in wordamount

            while (index >= 0 && !found)                                    // while statement to set found to true, if true
            {
                if (userinput >= wordamount[index])
                    found = true;
                else
                    --index;
            }

            if (userinput < 0)
                MessageBox.Show("Enter a valid number!");

            if (found)                                                      // if found = true
            {
                lettergrade = grades[index];                                // char value in grades arrary
                gradeoutput_label.Text = $"{lettergrade}";                  // outputs the value to the correct label
            }
        }

        private void Wordstyped_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
