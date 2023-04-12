// Grading ID: j3408
// Program 2
// 10/16/2019
// CIS 199-01

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

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_registration_button_Click(object sender, EventArgs e)
        {
            // credit hours

            double creditHrs;                                                             // variable for credit hours
            const int senior = 90;                                                        // integer for senior credits
            const int junior = 60;                                                        // integer for junior credits
            const int sophomore = 30;                                                     // integer for sophomore credits


            // char input from firstLetter_textbox 

            char ch;                                                                      // ch == input of credits from the user
            char.TryParse(firstLetter_txtbox.Text, out ch);                               // try.parse from first letter textbox, stores the input as 'ch'
            char.IsLetter(ch);                                                            // recognizes the ch input as unicode
            char.ToLower(ch);                                                             // recognizes entered lower case letter 

            // strings for all scheduled times

            string Time_Slot1 = "8:30AM";                                                 // 8:30AM
            string Time_Slot2 = "10:00AM";                                                // 10:30AM
            string Time_Slot3 = "11:30AM";                                                // 11:30AM
            string Time_Slot4 = "2:00PM";                                                 // 2:00PM
            string Time_Slot5 = "4:00PM";                                                 // 4:00PM

            // strings for all scheduled days

            string seniorDay = "Monday, November 4";                                      // NOV 4
            string juniorDay = "Tuesday, November 5";                                     // NOV 5
            string sophomoreDay1 = "Wednesday, November 6";                               // NOV 6
            string sophomoreDay2 = "Thursday, November 7";                                // NOV 7
            string freshmenDay1 = "Friday, November 8";                                   // NOV 8
            string freshmenDay2 = "Monday, November 11";                                  // NOV 11


            string dayResult;                                                             // string for if, else if statement results 
            string timeResult;                                                            // string for if, else if statement results

            if ((double.TryParse(creditHrs_txtbox.Text, out creditHrs) && (creditHrs >= 60)))   // try.parse from credit hours textbox, stores input as credithours and checks to see if you are an upper class men
            {

                if (creditHrs >= junior && creditHrs < senior)                                  // if statement to check if you are a junior
                {            /* JUNIOR */

                    if (char.TryParse(firstLetter_txtbox.Text, out ch))                         // try.parse from last letter textbox, stores the input as 'ch'
                    {
                        if (ch <= 'd')                                                          // if statement range check from a
                        {
                            timeResult = Time_Slot3;                                            // 11:30AM
                            dayResult = juniorDay;                                              // Tuesday, Nov 5
                        }
                        else if (ch <= 'i')                                                     // if statement range check
                        {
                            timeResult = Time_Slot4;                                            // 2:00PM
                            dayResult = juniorDay;                                              // Tuesday, Nov 5
                        }
                        else if (ch <= 'o')                                                     // if statement range check
                        {
                            timeResult = Time_Slot5;                                            // 4:00PM
                            dayResult = juniorDay;                                              // Tuesday, Nov 5
                        }
                        else if (ch <= 's')                                                     // if statement range check
                        {
                            timeResult = Time_Slot1;                                            // 8:30AM
                            dayResult = juniorDay;                                              // Tuesday, Nov 5
                        }
                        else                                                                    // if statement range check to z
                        {
                            timeResult = Time_Slot2;                                            // 10:00AM
                            dayResult = juniorDay;                                              // Tuesday, Nov 5
                        }

                        date_label.Text = $"{dayResult}";                                       // outputs dayresult to date label
                        time_label.Text = $"{timeResult}";                                      // outputs time result to time label
                    }
                }
                else /* SENIOR */
                {
            
                    if (char.TryParse(firstLetter_txtbox.Text, out ch))                          // try.parse from last letter textbox, stores the input as 'ch'
                    {
                        if (ch <= 'd')                                                           // if statement range check
                        {
                            timeResult = Time_Slot3;                                             // 11:30AM
                            dayResult = seniorDay;                                               // Monday, Nov 4
                        }
                        else if (ch <= 'i')                                                      // if statement range check
                        {       
                            timeResult = Time_Slot4;                                             // 2:00PM
                            dayResult = seniorDay;                                               // Monday, Nov 4
                        }
                        else if (ch <= 'o')                                                      // if statement range check
                        {
                            timeResult = Time_Slot5;                                             // 4:00PM
                            dayResult = seniorDay;                                               // Monday, Nov 4
                        }
                        else if (ch <= 's')                                                      // if statement range check
                        {
                            timeResult = Time_Slot1;                                             // 8:30AM
                            dayResult = seniorDay;                                               // Monday, Nov 4
                        }
                        else                                                                     // if statement range check
                        {
                            timeResult = Time_Slot2;                                             // 10:00AM
                            dayResult = seniorDay;                                               // Monday, Nov 4
                        }

                        date_label.Text = $"{dayResult}";                                        // outputs dayresult to date label
                        time_label.Text = $"{timeResult}";                                       // outputs time result to time label
                    }
                }
            }
            else                                                                           // -60
            {
                if (creditHrs < junior && creditHrs >= sophomore)                                // if statement to check if you are a sophomore
                {       /* SOPHOMORE */


                    if (char.TryParse(firstLetter_txtbox.Text, out ch))                          // try.parse from last letter textbox, stores the input as 'ch'
                    {

                        if (ch <= 'b')                                                           // if statement range check
                        {
                            timeResult = Time_Slot5;                                             // 4:00PM
                            dayResult = sophomoreDay1;                                           // Wednesday, Nov 6
                        }
                        else if ( ch <= 'd')                                                     // if statement range check
                        {
                            timeResult = Time_Slot1;                                             // 8:30AM
                            dayResult = sophomoreDay2;                                           // Thursday, Nov 7
                        }
                        else if (ch <= 'f')                                                      // if statement range check
                        {
                            timeResult = Time_Slot2;                                             // 10:00AM
                            dayResult = sophomoreDay2;                                           // Thursday, Nov 7
                        }
                        else if (ch <= 'i')                                                      // if statement range check
                        {
                            timeResult = Time_Slot3;                                             // 11:30AM
                            dayResult = sophomoreDay2;                                           // Thursday, Nov 7
                        }
                        else if (ch <= 'l')                                                      // if statement range check
                        {
                            timeResult = Time_Slot4;                                            // 2:00PM
                            dayResult = sophomoreDay2;                                          // Thursday, Nov 7
                        }
                        else if (ch <= 'o')                                                     // if statement range check
                        {
                            timeResult = Time_Slot5;                                            // 4:00PM
                            dayResult = sophomoreDay2;                                          // Thursday, Nov 7
                        }
                        else if (ch <= 'q')                                                     // if statement range check
                        {
                            timeResult = Time_Slot1;                                            // 8:30AM
                            dayResult = sophomoreDay1;                                          // Wednesday, Nov 6
                        }
                        else if (ch <= 'v')                                                     // if statement range check
                        {
                            timeResult = Time_Slot3;                                            // 11:30AM
                            dayResult = sophomoreDay1;                                          // Wednesday, Nov 6
                        }
                        else                                                                    // characters less than v
                        {
                            timeResult = Time_Slot4;                                            // 2:00PM
                            dayResult = sophomoreDay1;                                          // Wednesday, Nov 6
                        }

                        date_label.Text = $"{dayResult}";                                       // outputs dayresult to date label
                        time_label.Text = $"{timeResult}";                                      // outputs time result to time label
                    }
                }
                else 
                {       /* FRESHMEN */
                    if (char.TryParse(firstLetter_txtbox.Text, out ch))                         // try.parse from last letter textbox, stores the input as 'ch'
                    {

                        if (ch <= 'b')
                        {
                            timeResult = Time_Slot5;                                           // 4:00PM
                            dayResult = freshmenDay1;                                          // Friday, Nov 8 
                        }
                        else if (ch <= 'd')
                        {
                            timeResult = Time_Slot1;                                          // 8:30PM
                            dayResult = freshmenDay2;                                         // Monday, Nov 11
                        }
                        else if (ch <= 'f')
                        {
                            timeResult = Time_Slot2;                                          // 10:00PM
                            dayResult = freshmenDay2;                                         // Monday, Nov 11
                        }
                        else if (ch <= 'i')
                        {
                            timeResult = Time_Slot3;                                          // 11:30AM
                            dayResult = freshmenDay2;                                         // Monday, Nov 11
                        }
                        else if (ch <= 'l')
                        {
                            timeResult = Time_Slot4;                                          // 2:00PM
                            dayResult = freshmenDay2;                                         // Monday, Nov 11
                        }
                        else if (ch <= 'o')
                        {
                            timeResult = Time_Slot5;                                          // 4:00PM
                            dayResult = freshmenDay2;                                         // Monday, Nov 11
                        }
                        else if (ch <= 'q')
                        {
                            timeResult = Time_Slot1;                                          // 8:30AM
                            dayResult = freshmenDay1;                                         // Friday, Nov 8
                        }
                        else if (ch <= 's')
                        {
                            timeResult = Time_Slot2;                                         // 10:00AM
                            dayResult = freshmenDay1;                                        // Friday, Nov 8
                        }
                        else if (ch <= 'v')
                        {
                            timeResult = Time_Slot3;                                         // 11:30AM
                            dayResult = freshmenDay1;                                        // Friday, Nov 8
                        }
                        else
                        {
                            timeResult = Time_Slot4;                                         // 2:00PM
                            dayResult = freshmenDay1;                                        // Friday, Nov 8
                        }

                        date_label.Text = $"{dayResult}";                                    // outputs dayresult to date label
                        time_label.Text = $"{timeResult}";                                   // outputs time result to time label
                    }
                }
            }
        }
    }
}
