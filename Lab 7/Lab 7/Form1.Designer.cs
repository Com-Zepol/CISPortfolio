namespace Lab_7
{
    partial class Form1
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
            this.futurevalue_label = new System.Windows.Forms.Label();
            this.interestrate_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.pv_label = new System.Windows.Forms.Label();
            this.futurevalue_txt = new System.Windows.Forms.TextBox();
            this.interestrate_txt = new System.Windows.Forms.TextBox();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.presentvalue_label = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futurevalue_label
            // 
            this.futurevalue_label.AutoSize = true;
            this.futurevalue_label.Location = new System.Drawing.Point(32, 24);
            this.futurevalue_label.Name = "futurevalue_label";
            this.futurevalue_label.Size = new System.Drawing.Size(70, 13);
            this.futurevalue_label.TabIndex = 0;
            this.futurevalue_label.Text = "Future Value:";
            // 
            // interestrate_label
            // 
            this.interestrate_label.AutoSize = true;
            this.interestrate_label.Location = new System.Drawing.Point(32, 57);
            this.interestrate_label.Name = "interestrate_label";
            this.interestrate_label.Size = new System.Drawing.Size(107, 13);
            this.interestrate_label.TabIndex = 1;
            this.interestrate_label.Text = "Annual Interest Rate:";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(32, 91);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(64, 13);
            this.year_label.TabIndex = 2;
            this.year_label.Text = "No. of Year:";
            // 
            // pv_label
            // 
            this.pv_label.AutoSize = true;
            this.pv_label.Location = new System.Drawing.Point(32, 123);
            this.pv_label.Name = "pv_label";
            this.pv_label.Size = new System.Drawing.Size(76, 13);
            this.pv_label.TabIndex = 3;
            this.pv_label.Text = "Present Value:";
            // 
            // futurevalue_txt
            // 
            this.futurevalue_txt.Location = new System.Drawing.Point(154, 24);
            this.futurevalue_txt.Name = "futurevalue_txt";
            this.futurevalue_txt.Size = new System.Drawing.Size(100, 20);
            this.futurevalue_txt.TabIndex = 4;
            // 
            // interestrate_txt
            // 
            this.interestrate_txt.Location = new System.Drawing.Point(154, 54);
            this.interestrate_txt.Name = "interestrate_txt";
            this.interestrate_txt.Size = new System.Drawing.Size(100, 20);
            this.interestrate_txt.TabIndex = 5;
            // 
            // year_txt
            // 
            this.year_txt.Location = new System.Drawing.Point(154, 88);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(100, 20);
            this.year_txt.TabIndex = 6;
            // 
            // presentvalue_label
            // 
            this.presentvalue_label.AutoSize = true;
            this.presentvalue_label.Location = new System.Drawing.Point(151, 123);
            this.presentvalue_label.Name = "presentvalue_label";
            this.presentvalue_label.Size = new System.Drawing.Size(0, 13);
            this.presentvalue_label.TabIndex = 7;
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(111, 175);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(75, 23);
            this.calc_button.TabIndex = 8;
            this.calc_button.Text = "Calculate";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calc_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.presentvalue_label);
            this.Controls.Add(this.year_txt);
            this.Controls.Add(this.interestrate_txt);
            this.Controls.Add(this.futurevalue_txt);
            this.Controls.Add(this.pv_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.interestrate_label);
            this.Controls.Add(this.futurevalue_label);
            this.Name = "Form1";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futurevalue_label;
        private System.Windows.Forms.Label interestrate_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label pv_label;
        private System.Windows.Forms.TextBox futurevalue_txt;
        private System.Windows.Forms.TextBox interestrate_txt;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.Label presentvalue_label;
        private System.Windows.Forms.Button calc_button;
    }
}

