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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94");
        SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable dt;
        SqlDataAdapter adapt;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Register";
            label2.Text = "Username";
            label3.Text = "Password";
            button1.Text = "Submit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string insertQuery = "INSERT INTO tblFinalUser (Username, Password) VALUES (@username, @password)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully!");
                }
            }

            this.Close();
        }
    }
}