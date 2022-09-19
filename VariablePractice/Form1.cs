using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            outputLabel.Text = $"{playerName} is number {playerNumber}";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            //variables
            double hours = 25;
            double pay = 18.75;

            //calculations
            double earned = hours * pay;

            //output
            outputLabel.Text = $"{hours} hours at ${pay} per hour equals ${earned}";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            //variables
            double radius = 15;
            double pi = 3.14;

            //calculations
            double area = radius * radius * pi;

            //output
            outputLabel.Text = $"The area of a circle with a radius of {radius}cm is {area}cm ^ 2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            //variables
            double length = 8.5;
            double width = 6;
            double costPerMetre = 19.95;

            //calculations
            double area = length * width;
            double totalCost = area * costPerMetre;

            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m ^ 2";
            outputLabel.Text = $"\nThe cost to carpet this area at ${costPerMetre} per square metre is ${totalCost}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //variables
            double shirt = 12.49;
            double taxRate = 0.13;
            double tendered = 20;

            //calculations
            double taxAmount = taxRate * shirt;
            double total = taxAmount + shirt;
            double change = tendered - total;

            //output
            outputLabel.Text = $"Bill of Sale";
            outputLabel.Text += $"\n\nShirt:       {shirt}";
            outputLabel.Text += $"\n\nTax:         {taxAmount}";
            outputLabel.Text += $"\nTotal:       {total}";
            outputLabel.Text += $"\n\nTendered:    {tendered}";
            outputLabel.Text += $"\n\nChange:      {change}";
        }
    }
    }
