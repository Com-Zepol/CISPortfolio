// Program 3
// CIS 199-01
// Due: 11/07/2019
// By: J3408
// Rewrote sections of code from if statements deciding time and date decision to parrellal arrays using range matching

// This application calculates the earliest registration date
// and time for an undergraduate student given their class standing
// and last name.
// Decisions based on UofL Spring 2020 Priority Registration Schedule

// Solution 3
// This solution keeps the first letter of the last name as a char
// and uses if/else logic for the times.
// It uses defined strings for the dates and times to make it easier
// to maintain.
// It only uses programming elements introduced in the text or
// in class.
// This solution takes advantage of the fact that there really are
// only two different time patterns used. One for juniors and seniors
// and one for sophomores and freshmen. The pattern for sophomores
// and freshmen is complicated by the fact the certain letter ranges
// get one date and other letter ranges get another date.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Console;

namespace Prog3
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void FindRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "November 4"; // 1st day of registration
            const string DAY2 = "November 5"; // 2nd day of registration
            const string DAY3 = "November 6"; // 3rd day of registration
            const string DAY4 = "November 7";  // 4th day of registration
            const string DAY5 = "November 8";  // 5th day of registration
            const string DAY6 = "November 11";  // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            const float SOPHOMORE = 30; // Hours needed to be sophomore
            const float JUNIOR = 60;    // Hours needed to be junior
            const float SENIOR = 90;    // Hours needed to be senior

            string lastNameStr;         // Entered last name
            char lastNameLetterCh;      // First letter of last name, as char
            string dateStr = "Error";   // Holds date of registration
            string timeStr = "Error";   // Holds time of registration
            float creditHours;          // Previously earned credit hours
            bool isUpperClass;          // Upperclass or not?

            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case         // taking first letter from userinput string

                if (float.TryParse(creditHoursTxt.Text, out creditHours) && creditHours >= 0)
                {
                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (creditHours >= JUNIOR);                                 // junior and above is upperclassmen

                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {
                            if (creditHours >= SENIOR)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;
                                            
                                                /* J3408 */
                            char[] SeniorJuniorLastNameLetters = { 'A', 'E', 'J', 'P', 'T' };                 /* Char array of lower limit last name letters for seniors and juniors */
                            string[] FreshSophTimes = { TIME3, TIME4, TIME5, TIME1, TIME2 };                  /* String array of time slots for seniors and juniors */

                            bool found = false;                                                               /* Boolean variable set to false */
                            int index = SeniorJuniorLastNameLetters.Length - 1;                               /* Starting from the end of the array */

                            while (index >= 0 && !found)
                            {
                                if (lastNameLetterCh >= SeniorJuniorLastNameLetters[index])                    /* Sets the found to true if letter is found on array*/
                                    found = true;
                                else
                                    --index;
                            }

                            if (found)                                                                         /* When found (true) produces the following */
                            {
                                timeStr = FreshSophTimes[index];                                               /* When found on the parallel array sets the value to this string to display on GUI */
                            }
                        }
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE)
                            {
                                // A-B, P-Z on day one
                                if ((lastNameLetterCh <= 'B') ||  // <= B
                                    (lastNameLetterCh >= 'P'))    // >= P
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // A-B, P-Z on day one
                                if ((lastNameLetterCh <= 'B') ||  // <= B
                                    (lastNameLetterCh >= 'P'))    // >= P
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }
                                                /* J3408 */
                            char[] FreshSophLastNameLetters = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' };                     /* Char array of lower limit last name letters for freshmen and sophomore */
                            string[] FreshSophTimes = { TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4 };         /* String array of time slots for freshmen and sophomore */

                            bool found = false;                                                                                         /* Boolean variable set to false */
                            int index = FreshSophLastNameLetters.Length - 1;                                                            /* Starting from the end of the array */

                            while (index >= 0 && !found)
                            {
                                if (lastNameLetterCh >= FreshSophLastNameLetters[index])                                                /* Sets the found to true if letter is found on array*/
                                    found = true;
                                else
                                    --index;
                            }

                            if (found)                                                                                                  /* When found (true) produces the following */
                            {
                                timeStr = FreshSophTimes[index];                                                                        /* When found on the parallel array sets the value to this string to display on GUI */
                            }
                        }

                        // Output results
                        dateTimeLbl.Text = $"{dateStr} at {timeStr}";
                    }
                    else // Not A-Z
                        MessageBox.Show("Make sure last name starts with a letter!");
                }
                else
                    MessageBox.Show("Enter a valid number of credit hours!");
            }
            else // Empty textbox
                MessageBox.Show("Please enter last name!");
        }
    }
}
