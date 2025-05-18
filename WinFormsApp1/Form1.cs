using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WinFormsApp1

{
    public partial class SignupForm : Form
    {
        private LoginForm loginForm;
        public SignupForm()
        {
            InitializeComponent();
            MemberPanel.Visible = false;
            SupplierAdminPanel.Visible = false;
            loginForm = new LoginForm(this);

        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            string selectedRole = comboBox1.SelectedItem.ToString();
            if (selectedRole == "Member")
            {
                panelContainer.Controls.Add(MemberPanel);
                MemberPanel.Dock = DockStyle.Fill;
                MemberPanel.Visible = true;
                clearMemberPanelInputs();

            }
            else
            {
                panelContainer.Controls.Add(SupplierAdminPanel);
                SupplierAdminPanel.Dock = DockStyle.Fill;
                SupplierAdminPanel.Visible = true;
                clearAdminSupplierPanelInputs();
            }



        }

        public void clearAdminSupplierPanelInputs()
        {
            AdminSupplierEmailAddress.Clear();
            AdminSupplierConfirmPassword.Clear();
            AdminSupplierPassword.Clear();
            AdminSupplierPhone.Clear();
            AdminSupplierUsername.Clear();
        }
        public void clearMemberPanelInputs()
        {
            memberBillingAddress.Clear();
            memberBusinessAddress.Clear();
            memberPassword.Clear();
            memberConfirmPassword.Clear();
            memberPhone.Clear();
            memberUsername.Clear();
            memberCreditCard.Clear();
            memberEmailAddress.Clear();
            memberResidenceAddress.Clear();
        }





        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = AdminSupplierUsername.Text;
            string password = AdminSupplierPassword.Text;
            string confirmPassword = AdminSupplierConfirmPassword.Text;
            string phoneNumber = AdminSupplierPhone.Text;
            string emailAddress = AdminSupplierEmailAddress.Text;
            if (userName.Length == 0 || emailAddress.Length == 0 || confirmPassword.Length == 0 || password.Length == 0 || phoneNumber.Length == 0)
            {
                MessageBox.Show("One or more fields are empty!", "Signup failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (confirmPassword != password)
            {
                MessageBox.Show("Passwords don't match!", "Signup failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedRole = comboBox1.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=Movie Rental Management System;Integrated Security=True");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into " + selectedRole + "(name, password) values('" + userName + "','" + password + "');", con);
            myCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Account created!", "Signup succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearAdminSupplierPanelInputs();
            this.Hide();
            loginForm.Show();
            return;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void MemberSubmitButton_Click(object sender, EventArgs e)
        {
            string userName = memberUsername.Text;
            string password = memberPassword.Text;
            string confirmPassword = memberConfirmPassword.Text;
            string phoneNumber = memberPhone.Text;
            string emailAddress = memberEmailAddress.Text;
            string businessAddress = memberBusinessAddress.Text;
            string billingAddress = memberBillingAddress.Text;
            string residenceAddress = memberResidenceAddress.Text;
            string creditCard = memberCreditCard.Text;
            if (userName.Length == 0 || emailAddress.Length == 0 || confirmPassword.Length == 0 || password.Length == 0 || phoneNumber.Length == 0 || residenceAddress.Length == 0 || billingAddress.Length == 0 || businessAddress.Length == 0 || creditCard.Length == 0)
            {
                MessageBox.Show("One or more fields are empty!", "Signup failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (confirmPassword != password)
            {
                MessageBox.Show("Passwords don't match!", "Signup failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=Movie Rental Management System;Integrated Security=True");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into Member(name, email_address, password, phone_number, residence_address, business_address, credit_card, billing_address) values('" + userName + "', '" + emailAddress + "','" + password + "','" + phoneNumber + "','" + residenceAddress + "','" + businessAddress + "','" + creditCard+ "','" + billingAddress+ "');", con);
            myCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Account created!", "Signup succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearAdminSupplierPanelInputs();
            this.Hide();
            loginForm.Show();
            return;
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
