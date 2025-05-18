using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Movie_Rental_Management_App
{
    public partial class admin_accept : Form
    {
        public LoginForm loginForm;
        public admin_accept(LoginForm log)
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id, title, is_accepted FROM MovieTape WHERE is_accepted = 0";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                // Make checkbox column
                if (dataGridView1.Columns["is_accepted"] is DataGridViewCheckBoxColumn == false)
                {
                    dataGridView1.Columns["is_accepted"].ReadOnly = false;
                }

                dataGridView1.Columns["id"].ReadOnly = true; // Hide or lock ID
            }
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {

            string serverName = "MR_QUALITY";
            string databaseName = "Movie Rental Management System";
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["id"].Value == null) continue;

                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    bool isCompleted = Convert.ToBoolean(row.Cells["is_accepted"].Value);

                    string query = "UPDATE MovieTape SET is_accepted = @is_accepted WHERE id = @id";

                    if (isCompleted)
                    {
                        string query2;
                        query2 = "UPDATE MovieTape SET availability_status = 'Available'";
                        SqlCommand cmd2  = new SqlCommand(query2, conn);
                        cmd2.ExecuteNonQuery();

                    }


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@is_accepted", isCompleted);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                }

                MessageBox.Show("Changes saved!");
            }
            button1_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        [Obsolete]
        private void LoadReportToGrid(string query)
        {
            string serverName = "MR_QUALITY";
            string databaseName = "Movie Rental Management System";
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            string selectedReport = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedReport))
            {
                MessageBox.Show("Please select a report.");
                return;
            }

            string query = "";


            switch (selectedReport?.Substring(0, 1))
            {
                case "a":
                    query = @"SELECT TOP 1 WITH TIES g.name AS GenreName, COUNT(*) AS RentalCount
              FROM Rental r
              JOIN MovieTape m ON r.tape_id = m.id
              JOIN Genre g ON m.genre_id = g.id
              GROUP BY g.name
              ORDER BY COUNT(*) DESC";
                    break;
                case "b":
                    query = @"SELECT g.name AS GenreName
              FROM Genre g
              WHERE g.id NOT IN (
                  SELECT DISTINCT m.genre_id
                  FROM MovieTape m
                  JOIN Rental r ON m.id = r.tape_id
                  WHERE MONTH(r.rental_date) = MONTH(DATEADD(MONTH, -1, GETDATE()))
                    AND YEAR(r.rental_date) = YEAR(DATEADD(MONTH, -1, GETDATE())))";
                    break;
                case "c":
                    query = @"SELECT g.name AS GenreName, m.title AS MovieTitle, m.date_added
              FROM MovieTape m
              JOIN Genre g ON m.genre_id = g.id
              ORDER BY g.name, m.date_added";
                    break;
                case "d":
                    query = @"SELECT mem.id, mem.name, mem.email_address, COUNT(r.id) AS TotalRented
              FROM Member mem
              LEFT JOIN Rental r ON mem.id = r.member_id
              GROUP BY mem.id, mem.name, mem.email_address";
                    break;
                case "e":
                    query = @"SELECT g.name AS GenreName, COUNT(r.id) AS TotalRentals, 
                  SUM(m.rental_price) AS TotalIncome
              FROM Rental r
              JOIN MovieTape m ON r.tape_id = m.id
              JOIN Genre g ON m.genre_id = g.id
              GROUP BY g.name
              ORDER BY TotalRentals DESC";
                    break;
                case "f":
                    query = @"SELECT s.name AS SupplierName
              FROM Supplier s
              WHERE s.id NOT IN (
                  SELECT supplier_id
                  FROM MovieTape
                  WHERE date_added >= DATEADD(MONTH, -3, GETDATE()))";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                LoadReportToGrid(query);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        [Obsolete]
        private void button4_Click(object sender, EventArgs e)
        {
            string serverName = "MR_QUALITY";
            string databaseName = "Movie Rental Management System";
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id, title, availability_status FROM MovieTape WHERE availability_status = 'Available'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dataGridView3.Columns["Select"] == null)
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.HeaderText = "Select";
                    chk.Name = "Select";
                    dataGridView3.Columns.Add(chk);
                }

                dataGridView3.DataSource = dt;
            }
        }
        [Obsolete]
        private void buton5_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected first
            bool anySelected = dataGridView3.Rows.Cast<DataGridViewRow>()
                .Any(row => Convert.ToBoolean(row.Cells["Select"]?.Value) == true);

            if (!anySelected)
            {
                MessageBox.Show("Please select at least one movie to delete.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string serverName = "MR_QUALITY";
            string databaseName = "Movie Rental Management System";
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Start a transaction for atomic operations
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            int deletedCount = 0;

                            foreach (DataGridViewRow row in dataGridView3.Rows)
                            {
                                // Skip if not selected or if the row is a new row
                                if (row.IsNewRow ||
                                    !Convert.ToBoolean(row.Cells["Select"]?.Value) ||
                                    row.Cells["id"].Value == null)
                                {
                                    continue;
                                }

                                int id = Convert.ToInt32(row.Cells["id"].Value);

                                // First delete from child tables to maintain referential integrity
                                string[] childTables = { "Rental", "ActIn" };
                                foreach (string table in childTables)
                                {
                                    string childQuery = $"DELETE FROM {table} WHERE tape_id = @id";
                                    using (SqlCommand cmd = new SqlCommand(childQuery, conn, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@id", id);
                                        cmd.ExecuteNonQuery();
                                    }
                                }

                                // Then delete from MovieTape
                                string query = "DELETE FROM MovieTape WHERE id = @id";
                                using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@id", id);
                                    cmd.ExecuteNonQuery();
                                    deletedCount++;
                                }
                            }

                            // Commit only if all deletions succeeded
                            transaction.Commit();

                            MessageBox.Show($"Successfully deleted {deletedCount} movie(s).", "Deletion Complete",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            transaction.Rollback();
                            MessageBox.Show($"Error deleting movies: {ex.Message}", "Deletion Failed",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database error: {sqlEx.Message}", "Connection Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            button4_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void admin_accept_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void admin_accept_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }

        private void admin_accept_Load(object sender, EventArgs e)
        {

        }
    }
}
