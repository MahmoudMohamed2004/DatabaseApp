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
                currentTape.setDashboard(this);
                rentPanel.Controls.Add(currentTape);
                currentTape.Location = currentPointLocation;
                currentTape.Width = panel1.Width - 50;
                currentPointLocation.Y += currentTape.Height + 20;

            }
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
            this.refreshDashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
