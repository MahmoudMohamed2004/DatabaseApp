using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        SignupForm signupForm;
        memberDashboardForm memberDashboard;
        public LoginForm(SignupForm signupForm)
        {
            InitializeComponent();
            clearInputs();
            this.signupForm = signupForm;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupForm.clearMemberPanelInputs();
            signupForm.clearAdminSupplierPanelInputs();
            signupForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            signupForm.Close();
        }

        private void loginSubmitButton_Click(object sender, EventArgs e)
        {
            if (loginComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role!", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedRole = loginComboBox.SelectedItem.ToString();

            string userName = loginUsername.Text;
            string password = loginPassword.Text;

            string query;

            if (selectedRole == "Admin")
            {
                query = "SELECT admin_id FROM Admin WHERE name = @username AND password = @password";

            }
            else if (selectedRole == "Member")
            {

                query = "SELECT member_id FROM Member WHERE name = @username AND password = @password";
            }
            else
            {
                query = "SELECT supplier_id FROM Supplier WHERE name = @username AND password = @password";
            }
            ;

            SqlConnection con = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=System;Integrated Security=True");
            con.Open();

            SqlCommand myCommand = new SqlCommand(query, con);
            myCommand.Parameters.AddWithValue("@username", userName);
            myCommand.Parameters.AddWithValue("@password", password);
            object result = myCommand.ExecuteScalar();
            con.Close();

            if (result != null)
            {
                clearInputs();
                string userId = result.ToString();
                MessageBox.Show("Logged in successfully! userNumber: " + userId, "Login succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (selectedRole == "Member")
                {
                    this.Hide();
                    memberDashboard = new memberDashboardForm(this, userId);
                    memberDashboard.Show();

                }
                return;
            }

            MessageBox.Show("Incorrect username or password!", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;

        }
        public List<MovieTape> getAllMovieTapes()
        {
            var tapes = new List<MovieTape>();
            string query = "select * from MovieTape";
            SqlConnection con = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=System;Integrated Security=True");
            con.Open();
            SqlCommand myCommand = new SqlCommand(query, con);
            SqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                var tape = new MovieTape()
                {
                    id = reader.GetInt32(0),
                    title = reader.GetString(1),
                    rental_price = reader.GetDecimal(2),
                    availability_status = reader.GetString(3),
                    admin_id = reader.GetInt32(4),
                    supplier_id = reader.GetInt32(5),
                    added_date = reader.GetDateTime(6)
                };
                tape.updateTexts();
                tapes.Add(tape);

            }
            con.Close();
            return tapes;
        }

        public List<MovieTape> getRentedMovieTapesByUser(string userID)
        {
            var tapes = new List<MovieTape>();
            string query = "select DISTINCT  m.* from MovieTape m INNER JOIN Rental r ON r.member_id = " + userID + " AND m.tape_id = r.tape_id;";
            SqlConnection con = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=System;Integrated Security=True");
            con.Open();
            SqlCommand myCommand = new SqlCommand(query, con);
            SqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                var tape = new MovieTape()
                {
                    id = reader.GetInt32(0),
                    title = reader.GetString(1),
                    rental_price = reader.GetDecimal(2),
                    availability_status = reader.GetString(3),
                    admin_id = reader.GetInt32(4),
                    supplier_id = reader.GetInt32(5),
                    added_date = reader.GetDateTime(6)
                };
                tape.updateTexts();
                tapes.Add(tape);

            }
            con.Close();
            return tapes;
        }

        private void clearInputs()
        {
            loginUsername.Text = string.Empty;
            loginPassword.Text = string.Empty;
        }

        private void loginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
