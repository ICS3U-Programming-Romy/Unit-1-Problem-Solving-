/*
 * Created by: Romy I. Chu III
 * Created on: 15-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Changing Area and Perimeter
 * This program... Calculates the area and perimeter of a rectangle with the given values for
 *                 length and width given inputted by the user in text boxes.
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

namespace _9.ChangeAreaPerRomyCIII
{
    public partial class frmChangeAreaPer : Form
    {
        public frmChangeAreaPer()
        {
            InitializeComponent();

            //hides the labels at the start.
            lblPerimeter.Hide();
            lblArea.Hide();
            
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declares Variables
            double length, width, area, perimeter;

            //Shows the labels
            lblArea.Show();
            lblPerimeter.Show();

            //Declares an Int
            int moveOn = 0;
            moveOn = 0;

            
            try //"Try" to check if there are any errors
            {
                //Converts to string
                length = double.Parse(txtLength.Text);
                width = double.Parse(txtWidth.Text);

                //If there are no errors in the code the int moveOn stays at zero, therefore running the rest of the code.
                //If there ARE errors, catch runs and sets moveOn to 1, therefore preventing the rest of the code to run.
            }

            catch
            {
                lblPerimeter.Text = "Input a number!";
                lblArea.Text = "";
                moveOn = 1;
            }

            if (moveOn == 0)
            {
                //Converts to string
                length = double.Parse(txtLength.Text);
                width = double.Parse(txtWidth.Text);

                //Calculations
                perimeter = (2 * length) + (2 * width);
                area = length * width;

                //Prevents program from crashing when nothing is inputed.
                if (txtLength.Text == "")
                {
                    MessageBox.Show("Yo. Do you mind inputing a a number?");
                    return;
                }

                if (txtWidth.Text == "")
                {
                    MessageBox.Show("Yo. Do you mind inputing a a number?");
                    return;
                }

                //Changes the text
                lblPerimeter.Text = "The Perimeter is : " + Convert.ToString(perimeter) + " meters(m)";
                lblArea.Text = "The Area is : " + Convert.ToString(area) + " meters squared (m^2)";
            }

        }
    }
}