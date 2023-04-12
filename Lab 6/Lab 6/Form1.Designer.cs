namespace Lab_6
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
            this.wordstyped_label = new System.Windows.Forms.Label();
            this.wordstyped_txtbox = new System.Windows.Forms.TextBox();
            this.studentgrade_label = new System.Windows.Forms.Label();
            this.gradeoutput_label = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordstyped_label
            // 
            this.wordstyped_label.AutoSize = true;
            this.wordstyped_label.Location = new System.Drawing.Point(43, 43);
            this.wordstyped_label.Name = "wordstyped_label";
            this.wordstyped_label.Size = new System.Drawing.Size(193, 13);
            this.wordstyped_label.TabIndex = 0;
            this.wordstyped_label.Text = "Enter student\'s number of words typed: ";
            // 
            // wordstyped_txtbox
            // 
            this.wordstyped_txtbox.Location = new System.Drawing.Point(242, 40);
            this.wordstyped_txtbox.Name = "wordstyped_txtbox";
            this.wordstyped_txtbox.Size = new System.Drawing.Size(100, 20);
            this.wordstyped_txtbox.TabIndex = 1;
            this.wordstyped_txtbox.TextChanged += new System.EventHandler(this.Wordstyped_txtbox_TextChanged);
            // 
            // studentgrade_label
            // 
            this.studentgrade_label.AutoSize = true;
            this.studentgrade_label.Location = new System.Drawing.Point(149, 148);
            this.studentgrade_label.Name = "studentgrade_label";
            this.studentgrade_label.Size = new System.Drawing.Size(79, 13);
            this.studentgrade_label.TabIndex = 2;
            this.studentgrade_label.Text = "Student Grade:";
            // 
            // gradeoutput_label
            // 
            this.gradeoutput_label.AutoSize = true;
            this.gradeoutput_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeoutput_label.Location = new System.Drawing.Point(235, 148);
            this.gradeoutput_label.Name = "gradeoutput_label";
            this.gradeoutput_label.Size = new System.Drawing.Size(0, 13);
            this.gradeoutput_label.TabIndex = 3;
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(155, 95);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(75, 23);
            this.calc_button.TabIndex = 4;
            this.calc_button.Text = "Enter";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calc_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.gradeoutput_label);
            this.Controls.Add(this.studentgrade_label);
            this.Controls.Add(this.wordstyped_txtbox);
            this.Controls.Add(this.wordstyped_label);
            this.Name = "Form1";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordstyped_label;
        private System.Windows.Forms.TextBox wordstyped_txtbox;
        private System.Windows.Forms.Label studentgrade_label;
        private System.Windows.Forms.Label gradeoutput_label;
        private System.Windows.Forms.Button calc_button;
    }
}

