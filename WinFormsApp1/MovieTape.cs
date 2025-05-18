using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MovieTape : UserControl
    {
        public string userId;
        public int id;
        public string title;
        public decimal rental_price;
        public string availability_status;
        public int admin_id;
        public int supplier_id;
        public int genre_id;
        public DateTime added_date;
        memberDashboardForm memberDashboard;
        public MovieTape()
        {
            InitializeComponent();

        }

        public void setDashboard(memberDashboardForm d)
        {
            this.memberDashboard = d;
            this.userId =  d.getUserId();
            return;
        }

        public void updateTexts()
        {
            this.tapeId.Text = id.ToString();
            this.tapeTitle.Text = title.ToString();
            this.tapeRentalPrice.Text = rental_price.ToString();
            string genre = GetGenreNameById(genre_id);
            this.tapeGenre.Text = genre;
            this.tapeStatus.Text = availability_status.ToString();
            if(availability_status == "Rented")
            {
                this.tapeStatus.ForeColor = Color.Red;
            } else
            {
                this.tapeStatus.ForeColor= Color.Green;
            }
            this.tapeId.Text = id.ToString();
            this.tapeSupplier.Text = supplier_id.ToString();
            this.tapeReleaseDate.Text = added_date.ToString();
               
        }

        private void MovieTape_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public string GetGenreNameById(int genreId)
        {

            string connectionString = "Data Source=MR_QUALITY;Initial Catalog=Movie Rental Management System;Integrated Security=True";

            string query = "SELECT name FROM Genre WHERE id = " + genreId.ToString();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand myCommand = new SqlCommand(query, con);
            object result = myCommand.ExecuteScalar();
            con.Close();
            return result.ToString();

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Return Tape")
            {
                string query1 = "update MovieTape set availability_status = 'Available' where id = " + id;
                string query2 = "delete from Rental where member_id = " + userId + " AND tape_id = " + id.ToString() + ";";
                SqlConnection con1 = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=Movie Rental Management System;Integrated Security=True");
                con1.Open();
                SqlCommand myCommand1 = new SqlCommand(query1, con1);
                SqlCommand myCommand2 = new SqlCommand(query2, con1);
                myCommand1.ExecuteNonQuery();
                myCommand2.ExecuteNonQuery();
                con1.Close();
                memberDashboard.refreshRentDashboard();
                memberDashboard.updateDashboardByGenre();
                return;

            }

            else if (tapeStatus.Text == "Rented")

            {

                MessageBox.Show("Tape is already rented!", "Transaction Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {

                string query = "UPDATE MovieTape SET availability_status = 'Rented' WHERE id = " + id;
                string query2 = "insert into Rental values(" + id.ToString() + ", " + userId + ", '2023-05-16', '2023-05-15')";
                SqlConnection con = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=Movie Rental Management System;Integrated Security=True");
                con.Open();
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.ExecuteNonQuery();
                myCommand = new SqlCommand(query2, con);
                myCommand.ExecuteNonQuery();
                con.Close();
                memberDashboard.refreshRentDashboard();
                memberDashboard.updateDashboardByGenre();
            }
              

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
