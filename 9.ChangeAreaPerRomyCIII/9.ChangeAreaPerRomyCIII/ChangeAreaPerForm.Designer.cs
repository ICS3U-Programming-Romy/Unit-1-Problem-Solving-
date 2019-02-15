namespace _9.ChangeAreaPerRomyCIII
{
    partial class frmChangeAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(16, 42);
            this.lblLength.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(140, 30);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m) :";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(16, 87);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(134, 30);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (m) :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(16, 180);
            this.lblArea.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(258, 30);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "The Area is : ????????";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(16, 150);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(308, 30);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "The Perimeter is : ????????";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(156, 39);
            this.txtLength.MaxLength = 8;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(113, 37);
            this.txtLength.TabIndex = 4;
           // this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(474, 24);
            this.mnuStrip.TabIndex = 5;
            this.mnuStrip.Text = "menuStrip1";
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
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(156, 84);
            this.txtWidth.MaxLength = 8;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(113, 37);
            this.txtWidth.TabIndex = 6;
           // this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(297, 58);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 45);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmChangeAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(474, 233);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.mnuStrip);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frmChangeAreaPer";
            this.Text = "Changing Area and Perimeter by Romy I. Chu III";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
    }
}

