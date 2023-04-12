namespace Program_2
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
            this.firstLetter_label = new System.Windows.Forms.Label();
            this.creditHrs_label = new System.Windows.Forms.Label();
            this.firstLetter_txtbox = new System.Windows.Forms.TextBox();
            this.creditHrs_txtbox = new System.Windows.Forms.TextBox();
            this.earlyregistrationTITLE_label = new System.Windows.Forms.Label();
            this.date1_label = new System.Windows.Forms.Label();
            this.calc_registration_button = new System.Windows.Forms.Button();
            this.time1_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstLetter_label
            // 
            this.firstLetter_label.AutoSize = true;
            this.firstLetter_label.Location = new System.Drawing.Point(49, 79);
            this.firstLetter_label.Name = "firstLetter_label";
            this.firstLetter_label.Size = new System.Drawing.Size(181, 13);
            this.firstLetter_label.TabIndex = 0;
            this.firstLetter_label.Text = "Enter the first letter of your last name:";
            // 
            // creditHrs_label
            // 
            this.creditHrs_label.AutoSize = true;
            this.creditHrs_label.Location = new System.Drawing.Point(49, 119);
            this.creditHrs_label.Name = "creditHrs_label";
            this.creditHrs_label.Size = new System.Drawing.Size(116, 13);
            this.creditHrs_label.TabIndex = 1;
            this.creditHrs_label.Text = "Enter your credit hours:";
            // 
            // firstLetter_txtbox
            // 
            this.firstLetter_txtbox.Location = new System.Drawing.Point(236, 79);
            this.firstLetter_txtbox.Name = "firstLetter_txtbox";
            this.firstLetter_txtbox.Size = new System.Drawing.Size(100, 20);
            this.firstLetter_txtbox.TabIndex = 2;
            // 
            // creditHrs_txtbox
            // 
            this.creditHrs_txtbox.Location = new System.Drawing.Point(236, 116);
            this.creditHrs_txtbox.Name = "creditHrs_txtbox";
            this.creditHrs_txtbox.Size = new System.Drawing.Size(100, 20);
            this.creditHrs_txtbox.TabIndex = 3;
            // 
            // earlyregistrationTITLE_label
            // 
            this.earlyregistrationTITLE_label.AutoSize = true;
            this.earlyregistrationTITLE_label.Location = new System.Drawing.Point(82, 232);
            this.earlyregistrationTITLE_label.Name = "earlyregistrationTITLE_label";
            this.earlyregistrationTITLE_label.Size = new System.Drawing.Size(221, 13);
            this.earlyregistrationTITLE_label.TabIndex = 4;
            this.earlyregistrationTITLE_label.Text = "Your earliest registration date and time will be:";
            // 
            // date1_label
            // 
            this.date1_label.AutoSize = true;
            this.date1_label.Location = new System.Drawing.Point(151, 265);
            this.date1_label.Name = "date1_label";
            this.date1_label.Size = new System.Drawing.Size(33, 13);
            this.date1_label.TabIndex = 5;
            this.date1_label.Text = "Date:";
            // 
            // calc_registration_button
            // 
            this.calc_registration_button.Location = new System.Drawing.Point(155, 174);
            this.calc_registration_button.Name = "calc_registration_button";
            this.calc_registration_button.Size = new System.Drawing.Size(75, 23);
            this.calc_registration_button.TabIndex = 6;
            this.calc_registration_button.Text = "Search";
            this.calc_registration_button.UseVisualStyleBackColor = true;
            this.calc_registration_button.Click += new System.EventHandler(this.Calc_registration_button_Click);
            // 
            // time1_label
            // 
            this.time1_label.AutoSize = true;
            this.time1_label.Location = new System.Drawing.Point(151, 293);
            this.time1_label.Name = "time1_label";
            this.time1_label.Size = new System.Drawing.Size(33, 13);
            this.time1_label.TabIndex = 7;
            this.time1_label.Text = "Time:";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(190, 293);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(0, 13);
            this.time_label.TabIndex = 9;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(190, 265);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 13);
            this.date_label.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.calc_registration_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.time1_label);
            this.Controls.Add(this.calc_registration_button);
            this.Controls.Add(this.date1_label);
            this.Controls.Add(this.earlyregistrationTITLE_label);
            this.Controls.Add(this.creditHrs_txtbox);
            this.Controls.Add(this.firstLetter_txtbox);
            this.Controls.Add(this.creditHrs_label);
            this.Controls.Add(this.firstLetter_label);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLetter_label;
        private System.Windows.Forms.Label creditHrs_label;
        private System.Windows.Forms.TextBox firstLetter_txtbox;
        private System.Windows.Forms.TextBox creditHrs_txtbox;
        private System.Windows.Forms.Label earlyregistrationTITLE_label;
        private System.Windows.Forms.Label date1_label;
        private System.Windows.Forms.Button calc_registration_button;
        private System.Windows.Forms.Label time1_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label date_label;
    }
}

