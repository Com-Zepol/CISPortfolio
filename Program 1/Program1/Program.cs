// Grading ID: J3408
// Program 1
// 09/24/19
// CIS 199-01
// This program calculates the number of gallons needed to paint a room

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double wall_length; // wall length
            double wall_height; //  wall height
            const int door_In_Feet = 21; // feet for each door
            double perimeter; // length * height
            int number_of_doors; // user input for doors
            double total_number_doors; // variable to calculate the number of doors * each door (21ft)
            double doors_Subtract_From_Perimeter; // calculation for finding the total after subtracting doors from perimeter 

            // section 1 for wall length and height

            WriteLine("Welcome to the Handy-Dandy Paint Estimator"); // title
            WriteLine("                                          "); // line break

            Write("Enter the total length of all walls (in feet): "); // input for total length of all walls
            wall_length = double.Parse(ReadLine()); 

            Write("Enter the height of the walls (in feet): "); // input for height of walls
            wall_height = double.Parse(ReadLine());

            perimeter = wall_length * wall_height; // first calculation (perimeter)

            // section 2 for doors 

            Write("Enter the number of doors (non-neg int): "); // input for number of doors
            number_of_doors = int.Parse(ReadLine());

            total_number_doors = number_of_doors * door_In_Feet; // calculation for total number of doors * the value for each door
            doors_Subtract_From_Perimeter = perimeter - total_number_doors; // second calculation (perimeter - doors)


            // section 3 for windows 

            const int each_Window = 12; // feet for each door
            int number_Of_Windows; // user input for windows 
            double total_Number_Windows; // total after subtracting 
            double windows_Subtract_From_Perimeter; // variable for finding this total (see comment below)

            Write("Enter the number of windows (non-neg int): "); // input for number of windows
            number_Of_Windows = int.Parse(ReadLine());

            windows_Subtract_From_Perimeter = number_Of_Windows * each_Window; // calculation for finding the total from user input * each window (12f)
            total_Number_Windows = doors_Subtract_From_Perimeter - windows_Subtract_From_Perimeter; // third calculation (perimeter - walls - doors)

            // section 4 for coats of paint desired 

            double input_Coats; // user input for coats of paint
            double number_Of_Coats; // total number of coats (see comment below)

            Write("Enter the number of coats of paint (non-neg int): "); // user input for coats of paint
            input_Coats = int.Parse(ReadLine());

            number_Of_Coats = input_Coats * total_Number_Windows; // fourth calculation (third calc * number of paint coats)


            // section 5 for minimum coats of paint to buy

            const int can_Of_Paint = 400; // each can of paint covers 400ft
            double minimum_Number_Gallons; // total (see calculation below)
            minimum_Number_Gallons = number_Of_Coats / can_Of_Paint; // calculation for finding minimum number of coats / 400 (third calculation)

            // section 6 for recommending gallons of paint

            double gallonsToBuy; // variable for gallons
            gallonsToBuy = Math.Ceiling(minimum_Number_Gallons); // math.ceiling method to find the recommended gallons of paint

            WriteLine("                                          "); // line break
            WriteLine($"You need a minimum of {minimum_Number_Gallons:F1} gallons of paint"); // minimum amount 
            WriteLine($"You'll need to buy {gallonsToBuy} gallons, though"); // recommended amount
        }
    }
}
