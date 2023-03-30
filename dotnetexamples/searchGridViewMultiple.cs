using System.Data;
using System.Data.SqlClient;

namespace jhgfdsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "First Name";
            label2.Text = "Last Name";
            label3.Text = "Age";
            label4.Text = "Gender";
            label5.Text = "Department";
            button1.Text = "Search";

            button1_Click(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text.Trim();
    string lastname = textBox2.Text.Trim();
    string age = textBox3.Text.Trim();
    string gender = textBox4.Text.Trim();
    string department = textBox5.Text.Trim();
    string connectionString = "Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
    string sql = "SELECT FirstName, LastName, Age, Gender, Department FROM tblEMP WHERE FirstName LIKE @FirstName AND LastName LIKE @LastName AND Age LIKE @Age AND Gender LIKE @Gender AND Department LIKE @Department ORDER BY FirstName";
    SqlConnection connection = new SqlConnection(connectionString);
    SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
    dataadapter.SelectCommand.Parameters.AddWithValue("@FirstName", "%" + firstname + "%");
    dataadapter.SelectCommand.Parameters.AddWithValue("@LastName", "%" + lastname + "%");
    dataadapter.SelectCommand.Parameters.AddWithValue("@Age", "%" + age + "%");
    dataadapter.SelectCommand.Parameters.AddWithValue("@Gender", "%" + gender + "%");
    dataadapter.SelectCommand.Parameters.AddWithValue("@Department", "%" + department + "%");
    DataSet ds = new DataSet();
    connection.Open();
    dataadapter.Fill(ds, "tblEMP");
    dataGridView1.DataSource = ds;
    dataGridView1.DataMember = "tblEMP";
        }
    }
}
