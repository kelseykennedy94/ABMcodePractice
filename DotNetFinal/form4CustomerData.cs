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

namespace final
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94");
        SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable dt;
        SqlDataAdapter adapt;
        private object txtSearch;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string query = "SELECT * FROM tblFinalCustomer";
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
            button5.Text = "Go To Employee Data";
            button6.Text = "Search";
            button7.Text = "Age";
            button8.Text = "Name";
            button9.Text = "Gender";
            label1.Text = "Customer Data";
            label2.Text = "Name";
            label3.Text = "Phone";
            label4.Text = "Email";
            label5.Text = "Age";
            label6.Text = "Gender";
            label7.Text = "Filter By";
            label8.Text = "Sort By";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            string email = textBox3.Text;
            int age = Convert.ToInt32(textBox4.Text);
            string gender = textBox5.Text;

            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string insertQuery = "INSERT INTO tblFinalCustomer (Name, Phone, Email, Age, Gender) VALUES (@name, @phone, @email, @age, @gender)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer inserted successfully!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            string email = textBox3.Text;
            int age = Convert.ToInt32(textBox4.Text);
            string gender = textBox5.Text;

            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string updateQuery = "UPDATE tblFinalCustomer SET Phone=@phone, Email=@email, Age=@age, Gender=@gender WHERE Name=@name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer updated successfully!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();

                string deleteQuery = "DELETE FROM tblFinalCustomer WHERE Name=@name";
                using (SqlCommand command = new SqlCommand(deleteQuery, con))
                {
                    command.Parameters.AddWithValue("@name", name);
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!");
                        string selectQuery = "SELECT * FROM tblFinalCustomer";
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
            string selectQuery = "SELECT * FROM tblFinalCustomer";
            SqlDataAdapter adapt = new SqlDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{searchText}%'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblFinalCustomer ORDER BY Age ASC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblFinalCustomer ORDER BY Name ASC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string filterText = textBox5.Text.Trim();
            DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
            dv.RowFilter = string.Format("Gender LIKE '%{0}%'", filterText);
            DataTable filteredDT = dv.ToTable();
            dataGridView1.DataSource = filteredDT;
        }
    }
}
    
