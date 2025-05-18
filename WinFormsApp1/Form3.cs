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
using Movie_Rental_Management_App;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class memberDashboardForm : Form
    {

        private LoginForm loginForm;
        private string userId;

        public memberDashboardForm(LoginForm loginForm, string userID)
        {
            InitializeComponent();
            label1.Text = "Welcome user " + userID + "!";
            this.loginForm = loginForm;
            this.userId = userID;
            refreshDashboard();
            refreshRentDashboard();
            updateGenresComboBox();

        }
        public string getUserId() { return userId; }
        public void refreshDashboard()
        {
            var tapes = loginForm.getAllMovieTapes();
            panel1.Controls.Clear();
            Point currentPointLocation = new Point(0, 0);

            for (int i = 0; i < tapes.Count; i++)
            {
                if (tapes[i].availability_status == "InQueue")
                {
                    continue;
                }
                MovieTape currentTape = tapes[i];
                currentTape.setDashboard(this);
           
                panel1.Controls.Add(currentTape);
                currentTape.Location = currentPointLocation;
                currentTape.Width = panel1.Width - 50;
                currentPointLocation.Y += currentTape.Height + 20;

            }
        }

        public void refreshRentDashboard()
        {
            var tapes = loginForm.getRentedMovieTapesByUser(userId);
            rentPanel.Controls.Clear();
            Point currentPointLocation = new Point(0, 0);

            for (int i = 0; i < tapes.Count; i++)
            {

                MovieTape currentTape = tapes[i];
                if (currentTape.availability_status != "Rented")
                {
                    continue;
                }
                var ctrl = currentTape.Controls.Find("button1", true).FirstOrDefault();
                ctrl.Text = "Return Tape";
                var ctrl2 = currentTape.Controls.Find("tapeStatus", true).FirstOrDefault();
                ctrl2.ForeColor = Color.Orange;
                currentTape.setDashboard(this);
                rentPanel.Controls.Add(currentTape);
                currentTape.Location = currentPointLocation;
                currentTape.Width = panel1.Width - 50;
                currentPointLocation.Y += currentTape.Height + 20;
               

            }

        }
        public void refreshRentDashboardByGenre(string genre)
        {
            if (genre == "All")
            {
                refreshDashboard();
                return;
            }
            var tapes = loginForm.getAllMovieTapes();
            panel1.Controls.Clear();
            Point currentPointLocation = new Point(0, 0);

            for (int i = 0; i < tapes.Count; i++)
            {
                if (tapes[i].availability_status == "InQueue")
                {
                    continue;
                }
                MovieTape currentTape = tapes[i];
                string tapeGenre = GetGenreNameById(currentTape.genre_id);

                if (tapeGenre != genre)
                {
                    continue;
                }
                currentTape.setDashboard(this);
                panel1.Controls.Add(currentTape);
                currentTape.Location = currentPointLocation;
                currentTape.Width = panel1.Width - 50;
                currentPointLocation.Y += currentTape.Height + 20;

            }

        }

        public string GetGenreNameById(int genreId)
        {

            string connectionString = "Data Source=MR_QUALITY;Initial Catalog=System;Integrated Security=True";

            string query = "SELECT name FROM Genre WHERE genre_id = " + genreId.ToString();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand myCommand = new SqlCommand(query, con);
            object result = myCommand.ExecuteScalar();
            con.Close();
            return result.ToString();
           
        }




        private void memberDashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void memberDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void refreshDashBoardButton_Click(object sender, EventArgs e)
        {
            this.refreshRentDashboard();
            updateDashboardByGenre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        public void updateGenresComboBox()
        {
            var genres = loginForm.GetGenres();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.MaxDropDownItems = 8;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All");
            comboBox1.Items.AddRange(genres.ToArray());
            if (genres.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Text = "";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDashboardByGenre();
        }

        public  void updateDashboardByGenre()
        {
            string genre = comboBox1.Text;
            refreshRentDashboardByGenre(genre);
        }
    }
}
