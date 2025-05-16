namespace WinFormsApp1
{
    partial class memberDashboardForm
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
            panel1 = new Panel();
            refreshDashBoardButton = new Button();
            label1 = new Label();
            button1 = new Button();
            rentPanel = new Panel();
            button2 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(227, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 431);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // refreshDashBoardButton
            // 
            refreshDashBoardButton.Location = new Point(26, 408);
            refreshDashBoardButton.Name = "refreshDashBoardButton";
            refreshDashBoardButton.Size = new Size(195, 35);
            refreshDashBoardButton.TabIndex = 1;
            refreshDashBoardButton.Text = "Refresh Dashboard";
            refreshDashBoardButton.UseVisualStyleBackColor = true;
            refreshDashBoardButton.Click += refreshDashBoardButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 2;
            label1.Text = "Welcome User 1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 585);
            button1.Name = "button1";
            button1.Size = new Size(195, 38);
            button1.TabIndex = 3;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rentPanel
            // 
            rentPanel.AutoScroll = true;
            rentPanel.BorderStyle = BorderStyle.FixedSingle;
            rentPanel.Location = new Point(227, 460);
            rentPanel.Name = "rentPanel";
            rentPanel.Size = new Size(791, 163);
            rentPanel.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(12, 529);
            button2.Name = "button2";
            button2.Size = new Size(195, 41);
            button2.TabIndex = 5;
            button2.Text = "Member Details";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // memberDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 635);
            Controls.Add(button2);
            Controls.Add(rentPanel);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(refreshDashBoardButton);
            Controls.Add(panel1);
            Name = "memberDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Dashboard";
            FormClosed += memberDashboardForm_FormClosed;
            Load += memberDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button refreshDashBoardButton;
        private Label label1;
        private Button button1;
        private Panel rentPanel;
        private Button button2;
    }
}