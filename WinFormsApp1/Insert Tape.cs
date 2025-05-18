using System.Data.SqlClient;
using WinFormsApp1;


namespace Movie_Rental_Management_App
{
    public partial class Insert_Tape : Form
    {

        LoginForm loginForm;
        public Insert_Tape(LoginForm log)
        {
            InitializeComponent();
            loginForm = log;
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = "MR_QUALITY";
            string databaseName = "Movie Rental Management System";
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand myCommand = new SqlCommand(
                        "INSERT INTO MovieTape (title, rental_price, supplier_id, genre_id, date_added, availability_status, is_accepted)" +
                        " VALUES (@title, @rental_price, @supplier_id, @genre_id, @date_added, @availability_status, @is_accepted)", conn))
                    {
                        myCommand.Parameters.AddWithValue("@title", textBox1.Text.Trim());

                        float rentalPrice;
                        if (!float.TryParse(textBox2.Text.Trim(), out rentalPrice))
                        {
                            MessageBox.Show("Please enter a valid rental price");
                            return;
                        }
                        myCommand.Parameters.AddWithValue("@rental_price", rentalPrice);

                        int supplierId;
                        if (!int.TryParse(textBox3.Text.Trim(), out supplierId))
                        {
                            MessageBox.Show("Please enter a valid supplier ID");
                            return;
                        }
                        myCommand.Parameters.AddWithValue("@supplier_id", supplierId);

                        int genreId;
                        if (!int.TryParse(textBox4.Text.Trim(), out genreId))
                        {
                            MessageBox.Show("Please enter a valid genre ID");
                            return;
                        }
                        myCommand.Parameters.AddWithValue("@genre_id", genreId);

                        myCommand.Parameters.AddWithValue("@date_added", dateTimePicker1.Value);

                        myCommand.Parameters.AddWithValue("@availability_status", "Available");
                        myCommand.Parameters.AddWithValue("@is_accepted", 0);

                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Movie inserted successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting movie: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void Insert_Tape_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
    }
}
