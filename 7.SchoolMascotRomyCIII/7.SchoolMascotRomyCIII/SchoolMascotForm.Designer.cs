namespace _7.SchoolMascotRomyCIII
{
    partial class frmSchoolMascot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSchoolAndMascot = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchoolsList = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStJoseph = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.stMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchoolAndMascot.SuspendLayout();
            this.mnuSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSchoolAndMascot
            // 
            this.grbSchoolAndMascot.Controls.Add(this.label2);
            this.grbSchoolAndMascot.Controls.Add(this.label1);
            this.grbSchoolAndMascot.Location = new System.Drawing.Point(47, 70);
            this.grbSchoolAndMascot.Name = "grbSchoolAndMascot";
            this.grbSchoolAndMascot.Size = new System.Drawing.Size(200, 100);
            this.grbSchoolAndMascot.TabIndex = 0;
            this.grbSchoolAndMascot.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchoolsList});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(370, 24);
            this.mnuSchools.TabIndex = 1;
            this.mnuSchools.Text = "menuStrip1";
            // 
            // mniSchoolsList
            // 
            this.mniSchoolsList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniStJoseph,
            this.mniMotherTeresa,
            this.stMarksToolStripMenuItem});
            this.mniSchoolsList.Name = "mniSchoolsList";
            this.mniSchoolsList.Size = new System.Drawing.Size(60, 20);
            this.mniSchoolsList.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            // 
            // mniStJoseph
            // 
            this.mniStJoseph.Name = "mniStJoseph";
            this.mniStJoseph.Size = new System.Drawing.Size(152, 22);
            this.mniStJoseph.Text = "St. Joseph";
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(152, 22);
            this.mniMotherTeresa.Text = "Mother Teresa";
            // 
            // stMarksToolStripMenuItem
            // 
            this.stMarksToolStripMenuItem.Name = "stMarksToolStripMenuItem";
            this.stMarksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stMarksToolStripMenuItem.Text = "St. Mark\'s";
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(370, 245);
            this.Controls.Add(this.grbSchoolAndMascot);
            this.Controls.Add(this.mnuSchools);
            this.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuSchools;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot Program By Romy I. Chu III";
            this.grbSchoolAndMascot.ResumeLayout(false);
            this.grbSchoolAndMascot.PerformLayout();
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSchoolAndMascot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchoolsList;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniStJoseph;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
        private System.Windows.Forms.ToolStripMenuItem stMarksToolStripMenuItem;
    }
}

