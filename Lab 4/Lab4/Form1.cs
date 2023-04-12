// Grading ID: J3408
// Lab 4
// 09/28/19
// This program makes admission decisions for a university based on the criteria required

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

namespace Lab4
{
    public partial class Form1 : Form
    {
        private float accepted_counter = 0; // counter starting at zero for running totals
        private int rejected_counter = 0;   // counter starting at zero for running totals

        public Form1()
        {
            InitializeComponent();
        }

        private void Click_to_admit_Click(object sender, EventArgs e)
        {
            float gpa;      // variable for GPA
            int testscore;  // variable for test scores

            // Main section for TryParse statements, if-else, and the directions for the locations for the output

            if (float.TryParse(gpa_txtbox.Text, out gpa) && (int.TryParse(testscore_txtbox.Text, out testscore))) // 1st TryParse is for GPA textbox and input, 2nd TryParse is for test score textbox and input
            {                                                                                                     
                if (gpa >= 3.0 && testscore >= 60 || gpa < 3.0 && testscore >= 80)  // if statements for both GPA and Test Score accepted requirements
                {
                    ++accepted_counter;                                             // incremented counter for acceptance
                    accepted_counter_label.Text = $"{accepted_counter}";            // incremented counter for acceptance to the accepted counter label
                    acpt_or_rjct_label.Text = "Accept";                             // displays "accept" next to admissions decision
                }
                else
                {
                    ++rejected_counter;                                             // incremented counter for rejection
                    rejected_counter_label.Text = $"{rejected_counter}";            // incremented counter for rejection to the rejected counter label
                    acpt_or_rjct_label.Text = "Reject";                             // displays "reject" next to admissions decision
                }
            }

            // Limits GPA textbox to only accept relevant numbers

            if (float.TryParse(gpa_txtbox.Text, out gpa))                           // TryParse from GPA textbox to gpa variable
            {
                if (gpa < 0.0 || gpa > 4.0)                                         // if statement for outer numbers that are not included
                {
                    MessageBox.Show("Enter a valid GPA!");                          // alert message is input is outside range
                }
            }


            // Limits Test Score textbox to only accept relevant numbers

            if (int.TryParse(testscore_txtbox.Text, out testscore))                 // TryParse from Test Score textbox to testscore variable
            {
                if (testscore < 0 && testscore > 100)                               // if statement for outer numbers that are not included
                {
                    MessageBox.Show("Enter a valid test score!");                   // alert message is input is outside range
                }
            }
        }
    
    }
}
