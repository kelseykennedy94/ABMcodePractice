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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Please Login";
            label2.Text = "Username";
            label3.Text = "Password";
            label4.Text = "No Account?";
            button1.Text = "Login";
            button2.Text = "Register Here";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = @"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string selectQuery = "SELECT * FROM tblFinalUser WHERE Username=@username AND Password=@password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 registrationForm = new Form3();
            registrationForm.Show();
        }
    }
}
