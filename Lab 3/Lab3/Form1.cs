// Grading ID: J3408
// Lab 3
// 09/22/19
// Section 01
// This program has the user enter a sphere's radius which the program calculates diameter, surface area and volume from the input.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Caculate diameter, surface area, and volume
        private void Calc_button_Click(object sender, EventArgs e)
        {
            double diameter; // diameter  
            double surface_area; // surface area
            double volume; // volume
            double radius; // radius of a sphere

            radius = double.Parse(ROS_txtbox.Text); // converts input to double

            diameter = 2 * radius; // calculation for diameter
            surface_area = 4 * Math.PI * Math.Pow(radius,2); // calculation for surface area
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3; // calculation for volume

            diameter_output.Text = $"{diameter:F2}"; // displays diameter calculation to correct label
            surfacearea_output.Text = $"{surface_area:F2}"; // displays surface area calculation to correct label 
            volume_output.Text = $"{volume:F2}"; // displays volume output to correct label 
        }
    }
}
