/*
 * Created by: Romy I. Chu III
 * Created on: 20-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Circumference of a Circle
 * This program... Calculates the circumference of a circle with the radius, inputted by the user.
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

namespace _10.CircumferenceRChuIII
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
            lblCircumference.Hide();  //Hides the answer
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declares the variables
            double radius, circ;
            const double PI = Math.PI;

            //Converts whatevers in the text box to a double
            radius = double.Parse(txtRadius.Text);

            //Calculates the circumference
            circ = 2 * PI * radius;

            //Changes and shows the answer
            lblCircumference.Text = "The circumference is: " + Convert.ToString(circ);
            lblCircumference.Show();
        }
    }
}
