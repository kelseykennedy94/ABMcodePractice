using GSF.Adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94");
        SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable dt;
        SqlDataAdapter adapt;
        private object txtSearch;
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string query = "SELECT * FROM tblFinalEmployee";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            button1.Text = "Insert";
            button2.Text = "Update";
            button3.Text = "Delete";
            button4.Text = "Select";
            button5.Text = "Search";
            button6.Text = "Salary";
            button7.Text = "Name";
            button8.Text = "Position";
            button9.Text = "Exit";
            label1.Text = "Employee Data";
            label2.Text = "Name";
            label3.Text = "Email";
            label4.Text = "Gender";
            label5.Text = "Salary";
            label6.Text = "Position";
            label7.Text = "Start Date";
            label8.Text = "Filter By";
            label9.Text = "Sort By";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string gender = textBox3.Text;
            int salary = Convert.ToInt32(textBox4.Text);
            string position = textBox5.Text;
            DateTime startdate = DateTime.Parse(textBox6.Text);

            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string insertQuery = "INSERT INTO tblFinalEmployee (Name, Email, Gender, Salary, Position, StartDate) VALUES (@name, @email, @gender, @salary, @position, @startdate)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@salary", salary);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@startdate", startdate);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee inserted successfully!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string gender = textBox3.Text;
            int salary = Convert.ToInt32(textBox4.Text);
            string position = textBox5.Text;
            DateTime startdate = DateTime.Parse(textBox6.Text);

            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string updateQuery = "UPDATE tblFinalEmployee SET Email=@email, Gender=@gender, Salary=@salary, Position=@position, StartDate=@startdate WHERE Name=@name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@salary", salary);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@startdate", startdate);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee updated successfully!");
                    string selectQuery = "SELECT * FROM tblFinalEmployee";
                    SqlDataAdapter adapt = new SqlDataAdapter(selectQuery, connection);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();

                string deleteQuery = "DELETE FROM tblFinalEmployee WHERE Name=@name";
                using (SqlCommand command = new SqlCommand(deleteQuery, con))
                {
                    command.Parameters.AddWithValue("@name", name);
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!");
                        string selectQuery = "SELECT * FROM tblFinalEmployee";
                        SqlDataAdapter adapt = new SqlDataAdapter(selectQuery, con);
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM tblFinalEmployee";
            SqlDataAdapter adapt = new SqlDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblFinalEmployee ORDER BY Salary ASC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblFinalEmployee ORDER BY Name ASC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filterText = textBox5.Text.Trim();
            DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
            dv.RowFilter = string.Format("Position LIKE '%{0}%'", filterText);
            DataTable filteredDT = dv.ToTable();
            dataGridView1.DataSource = filteredDT;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{searchText}%'";
        }
    }
}