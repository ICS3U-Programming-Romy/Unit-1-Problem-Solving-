/*
 * Created by: Romy I. Chu III
 * Created on: 13-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
 * This program... Has a menu strip with menu items, each referring to different photos. 
 *                 When one of those menu items are clicked, it changes the image to the corresponding image.
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

namespace _8.MovingCatRomyCIII
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //Changes the picture box to show the first cat picture when the menu item is clicked
            this.picCats.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //Changes the picture box to show the second cat picture when the menu item is clicked
            this.picCats.Image = Properties.Resources.cat2;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Closes the form when the menu item is clicked
            this.Close();
        }
    }
}
