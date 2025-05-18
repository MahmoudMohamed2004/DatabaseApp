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
            tapeTitle = new Label();
            tapeRentalPrice = new Label();
            tapeGenre = new Label();
            tapeStatus = new Label();
            tapeId = new Label();
            tapeSupplier = new Label();
            tapeReleaseDate = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tapePrice = new Label();
            SuspendLayout();
            // 
            // tapeTitle
            // 
            tapeTitle.AutoSize = true;
            tapeTitle.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tapeTitle.Location = new Point(126, 19);
            tapeTitle.Name = "tapeTitle";
            tapeTitle.Size = new Size(83, 17);
            tapeTitle.TabIndex = 0;
            tapeTitle.Text = "Movie Tape";
            tapeTitle.Click += label1_Click;
            // 
            // tapeRentalPrice
            // 
            tapeRentalPrice.AutoSize = true;
            tapeRentalPrice.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            tapeRentalPrice.Location = new Point(503, 19);
            tapeRentalPrice.Name = "tapeRentalPrice";
            tapeRentalPrice.Size = new Size(83, 17);
            tapeRentalPrice.TabIndex = 4;
            tapeRentalPrice.Text = "Movie Tape";
            // 
            // tapeGenre
            // 
            tapeGenre.AutoSize = true;
            tapeGenre.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            tapeGenre.Location = new Point(299, 19);
            tapeGenre.Name = "tapeGenre";
            tapeGenre.Size = new Size(83, 17);
            tapeGenre.TabIndex = 5;
            tapeGenre.Text = "Movie Tape";
            // 
            // tapeStatus
            // 
            tapeStatus.AutoSize = true;
            tapeStatus.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            tapeStatus.Location = new Point(299, 64);
            tapeStatus.Name = "tapeStatus";
            tapeStatus.Size = new Size(83, 17);
            tapeStatus.TabIndex = 6;
            tapeStatus.Text = "Movie Tape";
            tapeStatus.Click += label4_Click;
            // 
            // tapeId
            // 
            tapeId.AutoSize = true;
            tapeId.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            tapeId.Location = new Point(600, 19);
            tapeId.Name = "tapeId";
            tapeId.Size = new Size(83, 17);
            tapeId.TabIndex = 7;
            tapeId.Text = "Movie Tape";
            // 
            // tapeSupplier
            // 
            tapeSupplier.AutoSize = true;
            tapeSupplier.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            tapeSupplier.Location = new Point(503, 67);
            tapeSupplier.Name = "tapeSupplier";
            tapeSupplier.Size = new Size(83, 17);
            tapeSupplier.TabIndex = 8;
            tapeSupplier.Text = "Movie Tape";
            tapeSupplier.Click += label6_Click;
            // 
            // tapeReleaseDate
            // 
            tapeReleaseDate.AutoSize = true;
            tapeReleaseDate.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            tapeReleaseDate.Location = new Point(126, 64);
            tapeReleaseDate.Name = "tapeReleaseDate";
            tapeReleaseDate.Size = new Size(83, 17);
            tapeReleaseDate.TabIndex = 9;
            tapeReleaseDate.Text = "Movie Tape";
            tapeReleaseDate.Click += label7_Click;
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
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(14, 16);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 11;
            label8.Text = "Movie Name: ";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(231, 16);
            label9.Name = "label9";
            label9.Size = new Size(54, 23);
            label9.TabIndex = 12;
            label9.Text = "Genre";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(231, 61);
            label10.Name = "label10";
            label10.Size = new Size(54, 23);
            label10.TabIndex = 13;
            label10.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(391, 16);
            label11.Name = "label11";
            label11.Size = new Size(94, 23);
            label11.TabIndex = 14;
            label11.Text = "Rental Price";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(391, 64);
            label12.Name = "label12";
            label12.Size = new Size(70, 23);
            label12.TabIndex = 15;
            label12.Text = "Supplier";
            label12.Click += label12_Click;
            // 
            // tapePrice
            // 
            tapePrice.AutoSize = true;
            tapePrice.BorderStyle = BorderStyle.FixedSingle;
            tapePrice.Font = new Font("Segoe UI", 12F);
            tapePrice.Location = new Point(14, 61);
            tapePrice.Name = "tapePrice";
            tapePrice.Size = new Size(101, 23);
            tapePrice.TabIndex = 16;
            tapePrice.Text = "Release Date";
            tapePrice.Click += label13_Click;
            // 
            // MovieTape
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(tapePrice);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(tapeReleaseDate);
            Controls.Add(tapeSupplier);
            Controls.Add(tapeId);
            Controls.Add(tapeStatus);
            Controls.Add(tapeGenre);
            Controls.Add(tapeRentalPrice);
            Controls.Add(tapeTitle);
            Name = "MovieTape";
            Size = new Size(1117, 111);
            Load += MovieTape_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tapeTitle;
        private Label tapeRentalPrice;
        private Label tapeGenre;
        private Label tapeStatus;
        private Label tapeId;
        private Label tapeSupplier;
        private Label tapeReleaseDate;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label tapePrice;
    }
}
