namespace _8.MovingCatRomyCIII
{
    partial class frmMovingCat
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
            this.mnuFileAndCat = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCats = new System.Windows.Forms.PictureBox();
            this.mnuFileAndCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFileAndCat
            // 
            this.mnuFileAndCat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.mnuFileAndCat.Location = new System.Drawing.Point(0, 0);
            this.mnuFileAndCat.Name = "mnuFileAndCat";
            this.mnuFileAndCat.Size = new System.Drawing.Size(288, 24);
            this.mnuFileAndCat.TabIndex = 0;
            this.mnuFileAndCat.Text = "File And Cat";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(98, 22);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(98, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // picCats
            // 
            this.picCats.Image = global::_8.MovingCatRomyCIII.Properties.Resources.cat2;
            this.picCats.Location = new System.Drawing.Point(81, 27);
            this.picCats.Name = "picCats";
            this.picCats.Size = new System.Drawing.Size(122, 127);
            this.picCats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCats.TabIndex = 1;
            this.picCats.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 194);
            this.Controls.Add(this.picCats);
            this.Controls.Add(this.mnuFileAndCat);
            this.MainMenuStrip = this.mnuFileAndCat;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat By Romy I. Chu III";
            this.mnuFileAndCat.ResumeLayout(false);
            this.mnuFileAndCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFileAndCat;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox picCats;
    }
}

