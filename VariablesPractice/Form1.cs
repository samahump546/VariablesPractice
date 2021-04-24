using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VariablesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gretzkyButton_Click(object sender, EventArgs e)
        {
            //Declare a string variable for player's name
            string playerName = "Wayne Gretzky";
            
            //Declare an integer variable for player's number
            int playerNumber = 99;

            //Display output "Wayne Gretzky is number 99" using values in the variables
            outputLabel.Text = $"{playerName} is number {playerNumber}";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            //Create a double variables for the radius: 15, pi: 3.14 and the area, caculate it and display it
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            outputLabel.Text = $"The area of a circle with a radius of {radius}cm is {area}cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            //Find the cost to carpet a room 8.5m by 6m if the carpet has a price of 19.95 per square meter and display it
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}";
            outputLabel.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per square meter is ${totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            //Calcualte and print a bill of sale
            ///A shirt was purchased for $12.49 and was paid with a $20 bill. 
            ///Calculate taxes, (HST = 13 %), total bill, and change. 
            double shirt = 12.49;
            double taxRate = 0.13;
            double tax = shirt * taxRate;
            double totalBill = shirt + tax;
            double tendered = 20;
            double change = tendered - totalBill;

            outputLabel.Text = $"Bill of Sale";
            outputLabel.Text += $"\n\nShirt:          {shirt}";
            outputLabel.Text += $"\n\nTax:            {tax}";
            outputLabel.Text += $"\nTotal:          {totalBill}";
            outputLabel.Text += $"\n\nTendered:   {tendered}";
            outputLabel.Text += $"\nChange:      {change}";
        }
    }
}
