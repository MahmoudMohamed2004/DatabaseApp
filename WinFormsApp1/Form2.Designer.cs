namespace WinFormsApp1
{
    partial class LoginForm
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
            button1 = new Button();
            label1 = new Label();
            loginUsername = new TextBox();
            loginPassword = new TextBox();
            label2 = new Label();
            loginSubmitButton = new Button();
            label10 = new Label();
            loginComboBox = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(943, 600);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Signup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(424, 141);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // loginUsername
            // 
            loginUsername.Location = new Point(424, 192);
            loginUsername.Multiline = true;
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(194, 29);
            loginUsername.TabIndex = 2;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(424, 298);
            loginPassword.Multiline = true;
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(194, 29);
            loginPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(424, 247);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // loginSubmitButton
            // 
            loginSubmitButton.Location = new Point(423, 351);
            loginSubmitButton.Name = "loginSubmitButton";
            loginSubmitButton.Size = new Size(195, 40);
            loginSubmitButton.TabIndex = 5;
            loginSubmitButton.Text = "Login";
            loginSubmitButton.UseVisualStyleBackColor = true;
            loginSubmitButton.Click += loginSubmitButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(423, 74);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 20;
            label10.Text = "Choose Role:";
            // 
            // loginComboBox
            // 
            loginComboBox.DisplayMember = "1";
            loginComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            loginComboBox.FormattingEnabled = true;
            loginComboBox.Items.AddRange(new object[] { "Admin", "Member", "Supplier" });
            loginComboBox.Location = new Point(423, 105);
            loginComboBox.Name = "loginComboBox";
            loginComboBox.Size = new Size(195, 23);
            loginComboBox.TabIndex = 19;
            loginComboBox.Tag = "";
            loginComboBox.SelectedIndexChanged += loginComboBox_SelectedIndexChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 635);
            Controls.Add(label10);
            Controls.Add(loginComboBox);
            Controls.Add(loginSubmitButton);
            Controls.Add(loginPassword);
            Controls.Add(label2);
            Controls.Add(loginUsername);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox loginUsername;
        private TextBox loginPassword;
        private Label label2;
        private Button loginSubmitButton;
        private Label label10;
        private ComboBox loginComboBox;
    }
}