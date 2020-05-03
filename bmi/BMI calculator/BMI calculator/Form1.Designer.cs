namespace BMI_calculator
{
    partial class BMICalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.convertbutton = new System.Windows.Forms.Button();
            this.weightbox = new System.Windows.Forms.TextBox();
            this.heightbox = new System.Windows.Forms.TextBox();
            this.bmibox = new System.Windows.Forms.TextBox();
            this.weightlable = new System.Windows.Forms.Label();
            this.heightlable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetbutton = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // convertbutton
            // 
            this.convertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.convertbutton.Location = new System.Drawing.Point(197, 12);
            this.convertbutton.Name = "convertbutton";
            this.convertbutton.Size = new System.Drawing.Size(85, 45);
            this.convertbutton.TabIndex = 0;
            this.convertbutton.Text = "Convert Measurements";
            this.convertbutton.UseVisualStyleBackColor = false;
            this.convertbutton.Click += new System.EventHandler(this.convertbutton_Click);
            // 
            // weightbox
            // 
            this.weightbox.Location = new System.Drawing.Point(12, 25);
            this.weightbox.Name = "weightbox";
            this.weightbox.Size = new System.Drawing.Size(159, 20);
            this.weightbox.TabIndex = 1;
            this.weightbox.Text = "kg";
            // 
            // heightbox
            // 
            this.heightbox.Location = new System.Drawing.Point(12, 75);
            this.heightbox.Name = "heightbox";
            this.heightbox.Size = new System.Drawing.Size(159, 20);
            this.heightbox.TabIndex = 2;
            this.heightbox.Text = "m";
            // 
            // bmibox
            // 
            this.bmibox.Location = new System.Drawing.Point(12, 135);
            this.bmibox.Name = "bmibox";
            this.bmibox.ReadOnly = true;
            this.bmibox.Size = new System.Drawing.Size(159, 20);
            this.bmibox.TabIndex = 3;
            // 
            // weightlable
            // 
            this.weightlable.AutoSize = true;
            this.weightlable.Location = new System.Drawing.Point(66, 9);
            this.weightlable.Name = "weightlable";
            this.weightlable.Size = new System.Drawing.Size(41, 13);
            this.weightlable.TabIndex = 4;
            this.weightlable.Text = "Weight";
            // 
            // heightlable
            // 
            this.heightlable.AutoSize = true;
            this.heightlable.Location = new System.Drawing.Point(66, 59);
            this.heightlable.Name = "heightlable";
            this.heightlable.Size = new System.Drawing.Size(38, 13);
            this.heightlable.TabIndex = 5;
            this.heightlable.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Body Mass Index";
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetbutton.Location = new System.Drawing.Point(197, 62);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(85, 45);
            this.resetbutton.TabIndex = 7;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Gray;
            this.calculate.Location = new System.Drawing.Point(197, 113);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(85, 45);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 133);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(324, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heightlable);
            this.Controls.Add(this.weightlable);
            this.Controls.Add(this.bmibox);
            this.Controls.Add(this.heightbox);
            this.Controls.Add(this.weightbox);
            this.Controls.Add(this.convertbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BMICalculator";
            this.Text = "BMICalculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertbutton;
        private System.Windows.Forms.TextBox weightbox;
        private System.Windows.Forms.TextBox heightbox;
        private System.Windows.Forms.TextBox bmibox;
        private System.Windows.Forms.Label weightlable;
        private System.Windows.Forms.Label heightlable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

