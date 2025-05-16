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
        string userId;
        public int id;
        public string title;
        public decimal rental_price;
        public string availability_status;
        public int admin_id;
        public int supplier_id;
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
            this.label1.Text = id.ToString();
            this.label2.Text = title.ToString();
            this.label3.Text = rental_price.ToString();
            this.label4.Text = availability_status.ToString();
            this.label5.Text = admin_id.ToString();
            this.label6.Text = supplier_id.ToString();
            this.label7.Text = added_date.ToString();
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
                string query1 = "update MovieTape set availability_status = 'Available' where tape_id = " + id;
                SqlConnection con1 = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=System;Integrated Security=True");
                con1.Open();
                SqlCommand myCommand1 = new SqlCommand(query1, con1);
                myCommand1.ExecuteNonQuery();
                con1.Close();
                memberDashboard.refreshRentDashboard();
                memberDashboard.refreshDashboard();
                return;

            }
            else if (label4.Text == "Rented")
            {
                MessageBox.Show("Tape is already rented!", "Transaction Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string query = "UPDATE MovieTape SET availability_status = 'Rented' WHERE tape_id = " + id;
                string query2 = "insert into Rental values(" + userId + ", " + id.ToString() + ", '2023-05-16', '2023-05-15', " + rental_price.ToString() + ")";
                SqlConnection con = new SqlConnection(@"Data Source=MR_QUALITY;Initial Catalog=System;Integrated Security=True");
                con.Open();
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.ExecuteNonQuery();
                myCommand = new SqlCommand(query2, con);
                myCommand.ExecuteNonQuery();
                con.Close();
                memberDashboard.refreshRentDashboard();
                memberDashboard.refreshDashboard();
            }
              

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
