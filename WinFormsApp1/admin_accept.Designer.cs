namespace Movie_Rental_Management_App
{
    partial class admin_accept
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dataGridView3 = new DataGridView();
            label3 = new Label();
            button4 = new Button();
            buton5 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 46);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(336, 495);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Location = new Point(0, 545);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(112, 22);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Location = new Point(224, 545);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(112, 22);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.Location = new Point(466, 545);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(112, 22);
            button3.TabIndex = 3;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 16);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 5;
            label1.Text = "View pending Movies to Accept";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(363, 71);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(318, 470);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "a. Most rented genres", "b. Genres with no rentals last month", "c. Added movies by genre and date", "d. Member info + rented count", "e. Top rented genres with total sales", "f. Suppliers with no movies in last 3 months" });
            comboBox1.Location = new Point(363, 46);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 16);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 8;
            label2.Text = "Choose report to generate";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.Info;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(708, 46);
            dataGridView3.Margin = new Padding(3, 2, 3, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(318, 495);
            dataGridView3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(812, 16);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 10;
            label3.Text = "Delete Movie Tape";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.Location = new Point(708, 545);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(112, 22);
            button4.TabIndex = 11;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buton5
            // 
            buton5.BackColor = SystemColors.Window;
            buton5.Location = new Point(914, 545);
            buton5.Margin = new Padding(3, 2, 3, 2);
            buton5.Name = "buton5";
            buton5.Size = new Size(112, 22);
            buton5.TabIndex = 12;
            buton5.Text = "Delete";
            buton5.UseVisualStyleBackColor = false;
            buton5.Click += buton5_Click;
            // 
            // button5
            // 
            button5.Location = new Point(967, 15);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // admin_accept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 576);
            Controls.Add(button5);
            Controls.Add(buton5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin_accept";
            Text = "admin_accept";
            FormClosing += admin_accept_FormClosing;
            FormClosed += admin_accept_FormClosed;
            Load += admin_accept_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridView dataGridView3;
        private Label label3;
        private Button button4;
        private Button buton5;
        private Button button5;
    }
}