namespace _10.CircumferenceRChuIII
{
    partial class frmCircumference
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
            this.mnuCircumference = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEnterRadius = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.mnuCircumference.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCircumference
            // 
            this.mnuCircumference.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuCircumference.Location = new System.Drawing.Point(0, 0);
            this.mnuCircumference.Name = "mnuCircumference";
            this.mnuCircumference.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.mnuCircumference.Size = new System.Drawing.Size(557, 27);
            this.mnuCircumference.TabIndex = 0;
            this.mnuCircumference.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 19);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblEnterRadius
            // 
            this.lblEnterRadius.AutoSize = true;
            this.lblEnterRadius.Location = new System.Drawing.Point(15, 36);
            this.lblEnterRadius.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnterRadius.Name = "lblEnterRadius";
            this.lblEnterRadius.Size = new System.Drawing.Size(296, 24);
            this.lblEnterRadius.TabIndex = 1;
            this.lblEnterRadius.Text = "Enter the radius of the circle (cm): ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(334, 84);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 42);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(318, 36);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(6);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(180, 29);
            this.txtRadius.TabIndex = 3;
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Location = new System.Drawing.Point(15, 162);
            this.lblCircumference.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(198, 24);
            this.lblCircumference.TabIndex = 4;
            this.lblCircumference.Text = "The circumference is: ";
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 211);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblEnterRadius);
            this.Controls.Add(this.mnuCircumference);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuCircumference;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCircumference";
            this.Text = "Circumference of a Circle By: Romy I. Chu III";
            this.mnuCircumference.ResumeLayout(false);
            this.mnuCircumference.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCircumference;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblEnterRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblCircumference;
    }
}

