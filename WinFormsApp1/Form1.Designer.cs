namespace WinFormsApp1
{
    partial class SignupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            MemberPanel = new Panel();
            MemberSubmitButton = new Button();
            memberBillingAddress = new TextBox();
            label6 = new Label();
            memberResidenceAddress = new TextBox();
            label7 = new Label();
            memberEmailAddress = new TextBox();
            label8 = new Label();
            memberPhone = new TextBox();
            label9 = new Label();
            memberBusinessAddress = new TextBox();
            label4 = new Label();
            memberConfirmPassword = new TextBox();
            label5 = new Label();
            memberPassword = new TextBox();
            label3 = new Label();
            memberUsername = new TextBox();
            label2 = new Label();
            SupplierAdminPanel = new Panel();
            AdminSupplierSubmitButton = new Button();
            AdminSupplierPhone = new TextBox();
            label14 = new Label();
            AdminSupplierConfirmPassword = new TextBox();
            label15 = new Label();
            AdminSupplierEmailAddress = new TextBox();
            label16 = new Label();
            AdminSupplierPassword = new TextBox();
            label17 = new Label();
            AdminSupplierUsername = new TextBox();
            label18 = new Label();
            panelContainer = new Panel();
            button1 = new Button();
            memberCreditCard = new TextBox();
            label11 = new Label();
            MemberPanel.SuspendLayout();
            SupplierAdminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 54);
            label1.TabIndex = 0;
            label1.Text = "Signup Form";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "1";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Member", "Supplier" });
            comboBox1.Location = new Point(49, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 23);
            comboBox1.TabIndex = 17;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(49, 84);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 18;
            label10.Text = "Choose Role:";
            label10.Click += label10_Click;
            // 
            // MemberPanel
            // 
            MemberPanel.Controls.Add(memberCreditCard);
            MemberPanel.Controls.Add(label11);
            MemberPanel.Controls.Add(MemberSubmitButton);
            MemberPanel.Controls.Add(memberBillingAddress);
            MemberPanel.Controls.Add(label6);
            MemberPanel.Controls.Add(memberResidenceAddress);
            MemberPanel.Controls.Add(label7);
            MemberPanel.Controls.Add(memberEmailAddress);
            MemberPanel.Controls.Add(label8);
            MemberPanel.Controls.Add(memberPhone);
            MemberPanel.Controls.Add(label9);
            MemberPanel.Controls.Add(memberBusinessAddress);
            MemberPanel.Controls.Add(label4);
            MemberPanel.Controls.Add(memberConfirmPassword);
            MemberPanel.Controls.Add(label5);
            MemberPanel.Controls.Add(memberPassword);
            MemberPanel.Controls.Add(label3);
            MemberPanel.Controls.Add(memberUsername);
            MemberPanel.Controls.Add(label2);
            MemberPanel.Location = new Point(487, 66);
            MemberPanel.Name = "MemberPanel";
            MemberPanel.Size = new Size(407, 430);
            MemberPanel.TabIndex = 19;
            MemberPanel.Paint += panel1_Paint;
            // 
            // MemberSubmitButton
            // 
            MemberSubmitButton.Location = new Point(203, 357);
            MemberSubmitButton.Name = "MemberSubmitButton";
            MemberSubmitButton.Size = new Size(173, 65);
            MemberSubmitButton.TabIndex = 16;
            MemberSubmitButton.Text = "Submit";
            MemberSubmitButton.UseVisualStyleBackColor = true;
            MemberSubmitButton.Click += MemberSubmitButton_Click;
            // 
            // memberBillingAddress
            // 
            memberBillingAddress.Location = new Point(203, 314);
            memberBillingAddress.Multiline = true;
            memberBillingAddress.Name = "memberBillingAddress";
            memberBillingAddress.Size = new Size(173, 24);
            memberBillingAddress.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(203, 273);
            label6.Name = "label6";
            label6.Size = new Size(141, 28);
            label6.TabIndex = 14;
            label6.Text = "Billing Address";
            // 
            // memberResidenceAddress
            // 
            memberResidenceAddress.Location = new Point(203, 234);
            memberResidenceAddress.Multiline = true;
            memberResidenceAddress.Name = "memberResidenceAddress";
            memberResidenceAddress.Size = new Size(173, 24);
            memberResidenceAddress.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(203, 193);
            label7.Name = "label7";
            label7.Size = new Size(173, 28);
            label7.TabIndex = 12;
            label7.Text = "Residence Address";
            // 
            // memberEmailAddress
            // 
            memberEmailAddress.Location = new Point(203, 150);
            memberEmailAddress.Multiline = true;
            memberEmailAddress.Name = "memberEmailAddress";
            memberEmailAddress.Size = new Size(173, 24);
            memberEmailAddress.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(203, 109);
            label8.Name = "label8";
            label8.Size = new Size(134, 28);
            label8.TabIndex = 10;
            label8.Text = "Email Address";
            label8.Click += label8_Click;
            // 
            // memberPhone
            // 
            memberPhone.Location = new Point(203, 70);
            memberPhone.Multiline = true;
            memberPhone.Name = "memberPhone";
            memberPhone.Size = new Size(173, 24);
            memberPhone.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(203, 29);
            label9.Name = "label9";
            label9.Size = new Size(144, 28);
            label9.TabIndex = 8;
            label9.Text = "Phone Number";
            // 
            // memberBusinessAddress
            // 
            memberBusinessAddress.Location = new Point(19, 314);
            memberBusinessAddress.Multiline = true;
            memberBusinessAddress.Name = "memberBusinessAddress";
            memberBusinessAddress.Size = new Size(173, 24);
            memberBusinessAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(19, 273);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 6;
            label4.Text = "Business Address";
            // 
            // memberConfirmPassword
            // 
            memberConfirmPassword.Location = new Point(19, 234);
            memberConfirmPassword.Multiline = true;
            memberConfirmPassword.Name = "memberConfirmPassword";
            memberConfirmPassword.Size = new Size(173, 24);
            memberConfirmPassword.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(19, 193);
            label5.Name = "label5";
            label5.Size = new Size(168, 28);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // memberPassword
            // 
            memberPassword.Location = new Point(19, 150);
            memberPassword.Multiline = true;
            memberPassword.Name = "memberPassword";
            memberPassword.Size = new Size(173, 24);
            memberPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(19, 109);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // memberUsername
            // 
            memberUsername.Location = new Point(19, 70);
            memberUsername.Multiline = true;
            memberUsername.Name = "memberUsername";
            memberUsername.Size = new Size(173, 24);
            memberUsername.TabIndex = 1;
            memberUsername.TextChanged += textBox1_TextChanged_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(19, 29);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 0;
            label2.Text = "Username";
            label2.Click += label2_Click_1;
            // 
            // SupplierAdminPanel
            // 
            SupplierAdminPanel.Controls.Add(AdminSupplierSubmitButton);
            SupplierAdminPanel.Controls.Add(AdminSupplierPhone);
            SupplierAdminPanel.Controls.Add(label14);
            SupplierAdminPanel.Controls.Add(AdminSupplierConfirmPassword);
            SupplierAdminPanel.Controls.Add(label15);
            SupplierAdminPanel.Controls.Add(AdminSupplierEmailAddress);
            SupplierAdminPanel.Controls.Add(label16);
            SupplierAdminPanel.Controls.Add(AdminSupplierPassword);
            SupplierAdminPanel.Controls.Add(label17);
            SupplierAdminPanel.Controls.Add(AdminSupplierUsername);
            SupplierAdminPanel.Controls.Add(label18);
            SupplierAdminPanel.Location = new Point(922, 156);
            SupplierAdminPanel.Name = "SupplierAdminPanel";
            SupplierAdminPanel.Size = new Size(407, 430);
            SupplierAdminPanel.TabIndex = 20;
            // 
            // AdminSupplierSubmitButton
            // 
            AdminSupplierSubmitButton.Location = new Point(19, 361);
            AdminSupplierSubmitButton.Name = "AdminSupplierSubmitButton";
            AdminSupplierSubmitButton.Size = new Size(357, 49);
            AdminSupplierSubmitButton.TabIndex = 16;
            AdminSupplierSubmitButton.Text = "Submit";
            AdminSupplierSubmitButton.UseVisualStyleBackColor = true;
            AdminSupplierSubmitButton.Click += button2_Click;
            // 
            // AdminSupplierPhone
            // 
            AdminSupplierPhone.Location = new Point(203, 70);
            AdminSupplierPhone.Multiline = true;
            AdminSupplierPhone.Name = "AdminSupplierPhone";
            AdminSupplierPhone.Size = new Size(173, 24);
            AdminSupplierPhone.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F);
            label14.Location = new Point(203, 29);
            label14.Name = "label14";
            label14.Size = new Size(144, 28);
            label14.TabIndex = 8;
            label14.Text = "Phone Number";
            // 
            // AdminSupplierConfirmPassword
            // 
            AdminSupplierConfirmPassword.Location = new Point(19, 235);
            AdminSupplierConfirmPassword.Multiline = true;
            AdminSupplierConfirmPassword.Name = "AdminSupplierConfirmPassword";
            AdminSupplierConfirmPassword.Size = new Size(173, 24);
            AdminSupplierConfirmPassword.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F);
            label15.Location = new Point(19, 194);
            label15.Name = "label15";
            label15.Size = new Size(168, 28);
            label15.TabIndex = 6;
            label15.Text = "Confirm Password";
            // 
            // AdminSupplierEmailAddress
            // 
            AdminSupplierEmailAddress.Location = new Point(203, 150);
            AdminSupplierEmailAddress.Multiline = true;
            AdminSupplierEmailAddress.Name = "AdminSupplierEmailAddress";
            AdminSupplierEmailAddress.Size = new Size(173, 24);
            AdminSupplierEmailAddress.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F);
            label16.Location = new Point(203, 109);
            label16.Name = "label16";
            label16.Size = new Size(134, 28);
            label16.TabIndex = 4;
            label16.Text = "Email Address";
            // 
            // AdminSupplierPassword
            // 
            AdminSupplierPassword.Location = new Point(19, 150);
            AdminSupplierPassword.Multiline = true;
            AdminSupplierPassword.Name = "AdminSupplierPassword";
            AdminSupplierPassword.Size = new Size(173, 24);
            AdminSupplierPassword.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F);
            label17.Location = new Point(19, 109);
            label17.Name = "label17";
            label17.Size = new Size(93, 28);
            label17.TabIndex = 2;
            label17.Text = "Password";
            // 
            // AdminSupplierUsername
            // 
            AdminSupplierUsername.Location = new Point(19, 70);
            AdminSupplierUsername.Multiline = true;
            AdminSupplierUsername.Name = "AdminSupplierUsername";
            AdminSupplierUsername.Size = new Size(173, 24);
            AdminSupplierUsername.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15F);
            label18.Location = new Point(19, 29);
            label18.Name = "label18";
            label18.Size = new Size(99, 28);
            label18.TabIndex = 0;
            label18.Text = "Username";
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(49, 156);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(407, 430);
            panelContainer.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(587, 576);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // memberCreditCard
            // 
            memberCreditCard.Location = new Point(19, 398);
            memberCreditCard.Multiline = true;
            memberCreditCard.Name = "memberCreditCard";
            memberCreditCard.Size = new Size(159, 24);
            memberCreditCard.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(19, 357);
            label11.Name = "label11";
            label11.Size = new Size(147, 28);
            label11.TabIndex = 17;
            label11.Text = "Credit Card No.";
            label11.Click += label11_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 635);
            Controls.Add(button1);
            Controls.Add(panelContainer);
            Controls.Add(SupplierAdminPanel);
            Controls.Add(MemberPanel);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup Form";
            Load += Form1_Load;
            MemberPanel.ResumeLayout(false);
            MemberPanel.PerformLayout();
            SupplierAdminPanel.ResumeLayout(false);
            SupplierAdminPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label10;
        private Panel MemberPanel;
        private Label label2;
        private TextBox memberBillingAddress;
        private Label label6;
        private TextBox memberResidenceAddress;
        private Label label7;
        private TextBox memberEmailAddress;
        private Label label8;
        private TextBox memberPhone;
        private Label label9;
        private TextBox memberBusinessAddress;
        private Label label4;
        private TextBox memberConfirmPassword;
        private Label label5;
        private TextBox memberPassword;
        private Label label3;
        private TextBox memberUsername;
        private Button MemberSubmitButton;
        private Label label18;
        private TextBox AdminSupplierUsername;
        private Label label17;
        private TextBox AdminSupplierPassword;
        private Label label16;
        private TextBox AdminSupplierEmailAddress;
        private Label label15;
        private TextBox AdminSupplierConfirmPassword;
        private Label label14;
        private TextBox AdminSupplierPhone;
        private Button AdminSupplierSubmitButton;
        private Panel SupplierAdminPanel;
        private Panel panelContainer;
        private Button button1;
        private TextBox memberCreditCard;
        private Label label11;
    }
}
