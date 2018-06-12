namespace CST_117_Project_1
{
    partial class frmCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnIndicator = new System.Windows.Forms.Panel();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnMass = new System.Windows.Forms.Button();
            this.btnDensity = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.txtFieldOne = new System.Windows.Forms.TextBox();
            this.txtFieldTwo = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblComponentOne = new System.Windows.Forms.Label();
            this.lblComponentTwo = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pnIndicator);
            this.panel1.Controls.Add(this.btnVolume);
            this.panel1.Controls.Add(this.btnMass);
            this.panel1.Controls.Add(this.btnDensity);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 342);
            this.panel1.TabIndex = 0;
            // 
            // pnIndicator
            // 
            this.pnIndicator.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnIndicator.Location = new System.Drawing.Point(144, 74);
            this.pnIndicator.Name = "pnIndicator";
            this.pnIndicator.Size = new System.Drawing.Size(10, 61);
            this.pnIndicator.TabIndex = 4;
            // 
            // btnVolume
            // 
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolume.Location = new System.Drawing.Point(0, 195);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(154, 61);
            this.btnVolume.TabIndex = 3;
            this.btnVolume.Text = "VOLUME";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnMass
            // 
            this.btnMass.FlatAppearance.BorderSize = 0;
            this.btnMass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMass.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMass.Location = new System.Drawing.Point(0, 135);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(154, 61);
            this.btnMass.TabIndex = 2;
            this.btnMass.Text = "MASS";
            this.btnMass.UseVisualStyleBackColor = true;
            this.btnMass.Click += new System.EventHandler(this.btnMass_Click);
            // 
            // btnDensity
            // 
            this.btnDensity.FlatAppearance.BorderSize = 0;
            this.btnDensity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDensity.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDensity.Location = new System.Drawing.Point(0, 74);
            this.btnDensity.Name = "btnDensity";
            this.btnDensity.Size = new System.Drawing.Size(154, 61);
            this.btnDensity.TabIndex = 1;
            this.btnDensity.Text = "DENSITY";
            this.btnDensity.UseVisualStyleBackColor = true;
            this.btnDensity.Click += new System.EventHandler(this.btnDensity_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 74);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "p · m · v";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 74);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(393, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(32, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calculate Density";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFormula.Location = new System.Drawing.Point(300, 108);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(134, 33);
            this.lblFormula.TabIndex = 3;
            this.lblFormula.Text = "p = m / V";
            this.lblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFieldOne
            // 
            this.txtFieldOne.Location = new System.Drawing.Point(391, 163);
            this.txtFieldOne.Name = "txtFieldOne";
            this.txtFieldOne.Size = new System.Drawing.Size(100, 31);
            this.txtFieldOne.TabIndex = 5;
            // 
            // txtFieldTwo
            // 
            this.txtFieldTwo.Location = new System.Drawing.Point(391, 206);
            this.txtFieldTwo.Name = "txtFieldTwo";
            this.txtFieldTwo.Size = new System.Drawing.Size(100, 31);
            this.txtFieldTwo.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(420, 269);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 61);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblComponentOne
            // 
            this.lblComponentOne.AutoSize = true;
            this.lblComponentOne.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentOne.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComponentOne.Location = new System.Drawing.Point(251, 163);
            this.lblComponentOne.Name = "lblComponentOne";
            this.lblComponentOne.Size = new System.Drawing.Size(79, 33);
            this.lblComponentOne.TabIndex = 7;
            this.lblComponentOne.Text = "mass";
            this.lblComponentOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComponentTwo
            // 
            this.lblComponentTwo.AutoSize = true;
            this.lblComponentTwo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentTwo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComponentTwo.Location = new System.Drawing.Point(251, 204);
            this.lblComponentTwo.Name = "lblComponentTwo";
            this.lblComponentTwo.Size = new System.Drawing.Size(116, 33);
            this.lblComponentTwo.TabIndex = 8;
            this.lblComponentTwo.Text = "volume";
            this.lblComponentTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNotice.Location = new System.Drawing.Point(346, 240);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 13);
            this.lblNotice.TabIndex = 9;
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(586, 342);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.lblComponentTwo);
            this.Controls.Add(this.lblComponentOne);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFieldTwo);
            this.Controls.Add(this.txtFieldOne);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCalculator";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnMass;
        private System.Windows.Forms.Button btnDensity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnIndicator;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.TextBox txtFieldOne;
        private System.Windows.Forms.TextBox txtFieldTwo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblComponentOne;
        private System.Windows.Forms.Label lblComponentTwo;
        private System.Windows.Forms.Label lblNotice;
    }
}

