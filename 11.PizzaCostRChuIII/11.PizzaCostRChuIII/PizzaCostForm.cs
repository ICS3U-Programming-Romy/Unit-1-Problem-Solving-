/*
 * Created by: Romy I. Chu III
 * Created on: 22-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Pizza Cost
 * This program... Calculates the cost of a pizza given the diameter in inches.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.PizzaCostRChuIII
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declares the variables
            double diameter, costTax;

            //Gets the diameter of the pizza
            diameter = (double)nudDiameter.Value;
            
            //Calculates the cost of the pizza
            if (diameter == 0)
            {
                costTax = 0;
            }
            else
            {
                costTax = (0.75 + 0.99 + (0.5 * diameter)) * 1.13;
            }

            lblCost.Text = "The cost of the Pizza (with tax) is : ";
            lblAnswer.Text = String.Format("${0:0.00}", costTax);
        }
    }
}
