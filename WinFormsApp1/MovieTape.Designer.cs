namespace WinFormsApp1
{
    partial class MovieTape
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(126, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 0;
            label1.Text = "Movie Tape";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(503, 19);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 4;
            label2.Text = "Movie Tape";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(299, 19);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 5;
            label3.Text = "Movie Tape";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(299, 64);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 6;
            label4.Text = "Movie Tape";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(600, 19);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 7;
            label5.Text = "Movie Tape";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(503, 67);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 8;
            label6.Text = "Movie Tape";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(126, 64);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 9;
            label7.Text = "Movie Tape";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(587, 67);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 10;
            button1.Text = "Rent";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(14, 16);
            label8.Name = "label8";
            label8.Size = new Size(106, 21);
            label8.TabIndex = 11;
            label8.Text = "Movie Name: ";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(231, 16);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 12;
            label9.Text = "Genre";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(231, 61);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 13;
            label10.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(391, 16);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 14;
            label11.Text = "Rental Price";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(391, 64);
            label12.Name = "label12";
            label12.Size = new Size(68, 21);
            label12.TabIndex = 15;
            label12.Text = "Supplier";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(14, 61);
            label13.Name = "label13";
            label13.Size = new Size(99, 21);
            label13.TabIndex = 16;
            label13.Text = "Release Date";
            label13.Click += label13_Click;
            // 
            // MovieTape
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MovieTape";
            Size = new Size(1117, 111);
            Load += MovieTape_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
