// Grading ID: J3408
// Lab 5
// 10/21/2019
// This program produces star patterns by using nested for loops


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wordamount = { 0, 16, 31, 51, 76 };
            char[] discounts = { 'F', 'D', 'C', 'B', 'A' };

            int userinput;
            bool found = false;
            char lettergrade;

            Write("Enter words typed per minute: ");
            userinput = int.Parse(ReadLine());

            int index = wordamount.Length - 1; 


            while (index >= 0 && !found)
            {
                if (userinput >= wordamount[index])
                    found = true;
                else
                    --index;
            }

            if (found)
            {
                lettergrade = discounts[index];
                WriteLine($"Discount = {lettergrade}");
            }


        }
    
    }
}
