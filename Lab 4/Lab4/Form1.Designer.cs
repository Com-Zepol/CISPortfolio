namespace Lab4
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
            this.gpa_label = new System.Windows.Forms.Label();
            this.testscore_label = new System.Windows.Forms.Label();
            this.AD_label = new System.Windows.Forms.Label();
            this.gpa_txtbox = new System.Windows.Forms.TextBox();
            this.testscore_txtbox = new System.Windows.Forms.TextBox();
            this.accepted_label = new System.Windows.Forms.Label();
            this.rejected_label = new System.Windows.Forms.Label();
            this.click_to_admit = new System.Windows.Forms.Button();
            this.accepted_counter_label = new System.Windows.Forms.Label();
            this.rejected_counter_label = new System.Windows.Forms.Label();
            this.acpt_or_rjct_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpa_label
            // 
            this.gpa_label.AutoSize = true;
            this.gpa_label.Location = new System.Drawing.Point(71, 56);
            this.gpa_label.Name = "gpa_label";
            this.gpa_label.Size = new System.Drawing.Size(133, 13);
            this.gpa_label.TabIndex = 0;
            this.gpa_label.Text = "Enter grade point average:";
            // 
            // testscore_label
            // 
            this.testscore_label.AutoSize = true;
            this.testscore_label.Location = new System.Drawing.Point(71, 96);
            this.testscore_label.Name = "testscore_label";
            this.testscore_label.Size = new System.Drawing.Size(133, 13);
            this.testscore_label.TabIndex = 1;
            this.testscore_label.Text = "Enter admission test score:";
            // 
            // AD_label
            // 
            this.AD_label.AutoSize = true;
            this.AD_label.Location = new System.Drawing.Point(114, 136);
            this.AD_label.Name = "AD_label";
            this.AD_label.Size = new System.Drawing.Size(101, 13);
            this.AD_label.TabIndex = 2;
            this.AD_label.Text = "Admission Decision:";
            // 
            // gpa_txtbox
            // 
            this.gpa_txtbox.Location = new System.Drawing.Point(210, 53);
            this.gpa_txtbox.Name = "gpa_txtbox";
            this.gpa_txtbox.Size = new System.Drawing.Size(54, 20);
            this.gpa_txtbox.TabIndex = 3;
            // 
            // testscore_txtbox
            // 
            this.testscore_txtbox.Location = new System.Drawing.Point(210, 93);
            this.testscore_txtbox.Name = "testscore_txtbox";
            this.testscore_txtbox.Size = new System.Drawing.Size(54, 20);
            this.testscore_txtbox.TabIndex = 4;
            // 
            // accepted_label
            // 
            this.accepted_label.AutoSize = true;
            this.accepted_label.Location = new System.Drawing.Point(31, 198);
            this.accepted_label.Name = "accepted_label";
            this.accepted_label.Size = new System.Drawing.Size(56, 13);
            this.accepted_label.TabIndex = 5;
            this.accepted_label.Text = "Accepted:";
            // 
            // rejected_label
            // 
            this.rejected_label.AutoSize = true;
            this.rejected_label.Location = new System.Drawing.Point(34, 228);
            this.rejected_label.Name = "rejected_label";
            this.rejected_label.Size = new System.Drawing.Size(53, 13);
            this.rejected_label.TabIndex = 6;
            this.rejected_label.Text = "Rejected:";
            // 
            // click_to_admit
            // 
            this.click_to_admit.Location = new System.Drawing.Point(123, 163);
            this.click_to_admit.Name = "click_to_admit";
            this.click_to_admit.Size = new System.Drawing.Size(75, 23);
            this.click_to_admit.TabIndex = 7;
            this.click_to_admit.Text = "Admit?";
            this.click_to_admit.UseVisualStyleBackColor = true;
            this.click_to_admit.Click += new System.EventHandler(this.Click_to_admit_Click);
            // 
            // accepted_counter_label
            // 
            this.accepted_counter_label.AutoSize = true;
            this.accepted_counter_label.Location = new System.Drawing.Point(84, 198);
            this.accepted_counter_label.Name = "accepted_counter_label";
            this.accepted_counter_label.Size = new System.Drawing.Size(13, 13);
            this.accepted_counter_label.TabIndex = 8;
            this.accepted_counter_label.Text = "0";
            // 
            // rejected_counter_label
            // 
            this.rejected_counter_label.AutoSize = true;
            this.rejected_counter_label.Location = new System.Drawing.Point(84, 228);
            this.rejected_counter_label.Name = "rejected_counter_label";
            this.rejected_counter_label.Size = new System.Drawing.Size(13, 13);
            this.rejected_counter_label.TabIndex = 9;
            this.rejected_counter_label.Text = "0";
            // 
            // acpt_or_rjct_label
            // 
            this.acpt_or_rjct_label.AutoSize = true;
            this.acpt_or_rjct_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acpt_or_rjct_label.Location = new System.Drawing.Point(222, 136);
            this.acpt_or_rjct_label.Name = "acpt_or_rjct_label";
            this.acpt_or_rjct_label.Size = new System.Drawing.Size(0, 13);
            this.acpt_or_rjct_label.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.click_to_admit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.acpt_or_rjct_label);
            this.Controls.Add(this.rejected_counter_label);
            this.Controls.Add(this.accepted_counter_label);
            this.Controls.Add(this.click_to_admit);
            this.Controls.Add(this.rejected_label);
            this.Controls.Add(this.accepted_label);
            this.Controls.Add(this.testscore_txtbox);
            this.Controls.Add(this.gpa_txtbox);
            this.Controls.Add(this.AD_label);
            this.Controls.Add(this.testscore_label);
            this.Controls.Add(this.gpa_label);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpa_label;
        private System.Windows.Forms.Label testscore_label;
        private System.Windows.Forms.Label AD_label;
        private System.Windows.Forms.TextBox gpa_txtbox;
        private System.Windows.Forms.TextBox testscore_txtbox;
        private System.Windows.Forms.Label accepted_label;
        private System.Windows.Forms.Label rejected_label;
        private System.Windows.Forms.Button click_to_admit;
        private System.Windows.Forms.Label accepted_counter_label;
        private System.Windows.Forms.Label rejected_counter_label;
        private System.Windows.Forms.Label acpt_or_rjct_label;
    }
}

