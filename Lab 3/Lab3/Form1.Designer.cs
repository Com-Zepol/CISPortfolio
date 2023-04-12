namespace Lab3
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
            this.ROS_label = new System.Windows.Forms.Label();
            this.ROS_txtbox = new System.Windows.Forms.TextBox();
            this.calc_button = new System.Windows.Forms.Button();
            this.diameter_label = new System.Windows.Forms.Label();
            this.surfacearea_label = new System.Windows.Forms.Label();
            this.volume_label = new System.Windows.Forms.Label();
            this.diameter_output = new System.Windows.Forms.Label();
            this.surfacearea_output = new System.Windows.Forms.Label();
            this.volume_output = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ROS_label
            // 
            this.ROS_label.AutoSize = true;
            this.ROS_label.Location = new System.Drawing.Point(168, 76);
            this.ROS_label.Name = "ROS_label";
            this.ROS_label.Size = new System.Drawing.Size(92, 13);
            this.ROS_label.TabIndex = 0;
            this.ROS_label.Text = "Radius of Sphere:";
            // 
            // ROS_txtbox
            // 
            this.ROS_txtbox.Location = new System.Drawing.Point(263, 73);
            this.ROS_txtbox.Name = "ROS_txtbox";
            this.ROS_txtbox.Size = new System.Drawing.Size(100, 20);
            this.ROS_txtbox.TabIndex = 1;
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(276, 108);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(75, 23);
            this.calc_button.TabIndex = 2;
            this.calc_button.Text = "Calculate";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // diameter_label
            // 
            this.diameter_label.AutoSize = true;
            this.diameter_label.Location = new System.Drawing.Point(26, 207);
            this.diameter_label.Name = "diameter_label";
            this.diameter_label.Size = new System.Drawing.Size(49, 13);
            this.diameter_label.TabIndex = 3;
            this.diameter_label.Text = "Diameter";
            // 
            // surfacearea_label
            // 
            this.surfacearea_label.AutoSize = true;
            this.surfacearea_label.Location = new System.Drawing.Point(6, 245);
            this.surfacearea_label.Name = "surfacearea_label";
            this.surfacearea_label.Size = new System.Drawing.Size(69, 13);
            this.surfacearea_label.TabIndex = 4;
            this.surfacearea_label.Text = "Surface Area";
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(26, 283);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(42, 13);
            this.volume_label.TabIndex = 5;
            this.volume_label.Text = "Volume";
            // 
            // diameter_output
            // 
            this.diameter_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameter_output.Location = new System.Drawing.Point(81, 206);
            this.diameter_output.Name = "diameter_output";
            this.diameter_output.Size = new System.Drawing.Size(100, 20);
            this.diameter_output.TabIndex = 9;
            // 
            // surfacearea_output
            // 
            this.surfacearea_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfacearea_output.Location = new System.Drawing.Point(81, 244);
            this.surfacearea_output.Name = "surfacearea_output";
            this.surfacearea_output.Size = new System.Drawing.Size(100, 20);
            this.surfacearea_output.TabIndex = 10;
            // 
            // volume_output
            // 
            this.volume_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volume_output.Location = new System.Drawing.Point(81, 282);
            this.volume_output.Name = "volume_output";
            this.volume_output.Size = new System.Drawing.Size(100, 20);
            this.volume_output.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Lab3.Properties.Resources.Sphere_and_Ball1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Lab3.Properties.Resources.Sphere_and_Ball1;
            this.pictureBox2.Location = new System.Drawing.Point(213, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calc_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.volume_output);
            this.Controls.Add(this.surfacearea_output);
            this.Controls.Add(this.diameter_output);
            this.Controls.Add(this.volume_label);
            this.Controls.Add(this.surfacearea_label);
            this.Controls.Add(this.diameter_label);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.ROS_txtbox);
            this.Controls.Add(this.ROS_label);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ROS_label;
        private System.Windows.Forms.TextBox ROS_txtbox;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.Label diameter_label;
        private System.Windows.Forms.Label surfacearea_label;
        private System.Windows.Forms.Label volume_label;
        private System.Windows.Forms.Label diameter_output;
        private System.Windows.Forms.Label surfacearea_output;
        private System.Windows.Forms.Label volume_output;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

