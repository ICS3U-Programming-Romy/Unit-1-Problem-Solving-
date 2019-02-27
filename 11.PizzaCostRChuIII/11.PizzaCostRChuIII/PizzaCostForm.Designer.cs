namespace _11.PizzaCostRChuIII
{
    partial class frmPizzaCost
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
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblEnterDiameter = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDiameter
            // 
            this.nudDiameter.Location = new System.Drawing.Point(434, 23);
            this.nudDiameter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(125, 31);
            this.nudDiameter.TabIndex = 0;
            // 
            // lblEnterDiameter
            // 
            this.lblEnterDiameter.AutoSize = true;
            this.lblEnterDiameter.Location = new System.Drawing.Point(15, 25);
            this.lblEnterDiameter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnterDiameter.Name = "lblEnterDiameter";
            this.lblEnterDiameter.Size = new System.Drawing.Size(407, 25);
            this.lblEnterDiameter.TabIndex = 1;
            this.lblEnterDiameter.Text = "What size Pizza do you want?  (Inches) : ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 94);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(347, 25);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "The cost of the Pizza (with tax) is : ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 58);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 33);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(365, 94);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 25);
            this.lblAnswer.TabIndex = 4;
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 224);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblEnterDiameter);
            this.Controls.Add(this.nudDiameter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost By Romy I. Chu III";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblEnterDiameter;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswer;
    }
}

