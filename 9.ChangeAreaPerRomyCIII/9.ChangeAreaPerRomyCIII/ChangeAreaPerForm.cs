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
            lblArea.Hide();
            lblPerimeter.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Text Boxes
        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only positive numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

                //Error message if the user tries to use anything but digits or periods.
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                    MessageBox.Show("Input must be a positive number. No letters or negatives");
                }

            //This if statement prevents there from being more than 1 '.' in the text box.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allows only positive numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

                //Error message if the user tries to use anything but digits or periods.
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                    MessageBox.Show("Input must be a positive number. No letters or negatives");
                }

            //This if statement prevents there from being more than 1 '.' in the text box.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declares Variables
            double length, width, area, perimeter;

            //Converts to string
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //Calculations
            perimeter = (2 * length) + (2 * width);
            area = length * width;

            //Prevents program from crashing when nothing is inputed.
            #region Fail Safes
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
            #endregion

            //Shows the labels
            lblPerimeter.Show();
            lblArea.Show();
            //Changes the text
            lblPerimeter.Text = "The Perimeter is : " + Convert.ToString(perimeter) + " meters(m)";
            lblArea.Text = "The Area is : " + Convert.ToString(area) + " meters squared (m^2)";
        }
    }
}
