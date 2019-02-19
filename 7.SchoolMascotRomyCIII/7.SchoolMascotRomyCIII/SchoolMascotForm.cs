/*
 * Created by: Romy I. Chu III
 * Created on: 12-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - School Mascot
 * This program... Displays a menu strip with menu items corresponding to different school. When each of those menu items are clicked, 
 *                 the "School" and "Mascot" labels with change to the respective school.
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

namespace _7.SchoolMascotRomyCIII
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            //Changes the labels to the respective text
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }

        private void mniStJoseph_Click(object sender, EventArgs e)
        {
            //Changes the labels to the respective text
            lblSchool.Text = "St. Joseph";
            lblMascot.Text = "Hawks";
        }

        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            //Changes the labels to the respective text
            lblSchool.Text = "Mother Teresa";
            lblMascot.Text = "I Dunno";
        }

        private void stMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes the labels to the respective text
            lblSchool.Text = "St. Marks";
            lblMascot.Text = "Lions";

        }
    }
}
