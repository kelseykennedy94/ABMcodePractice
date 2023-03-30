
using System.Data;
using System.Data.SqlClient;

namespace tablesSQL
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Name:";
            label2.Text = "Age:";
            label3.Text = "Gender:";
            label4.Text = "Salary:";
            label5.Text = "Department:";
            label6.Text = "Team Lead:";
            label7.Text = "isCurrentEmployee:";
            button1.Text = "Enter Employee Data";
            button2.Text = "Search for Employee";
            checkBox1.Text = "";

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Check";
            chk.Name = "chk";
            dataGridView1.Columns.Insert(0, chk);

            fncFillGrid();
        }

        public void fncFillGrid()
        {
            string connectionstring = "Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string sql = "SELECT * FROM tblEmployee";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tblEmployee");
            connection.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = 0;
            if (!string.IsNullOrEmpty(textBox2.Text))
                age = int.Parse(textBox2.Text);
            string gender = textBox3.Text;
            decimal salary = 0;
            if (!string.IsNullOrEmpty(textBox4.Text))
                salary = decimal.Parse(textBox4.Text);
            string department = textBox5.Text;
            string? teamLead = null;
            if (!string.IsNullOrEmpty(textBox6.Text))
                teamLead = textBox6.Text;
            bool? isCurrentEmployee = null;
            if (checkBox1.Checked)
                isCurrentEmployee = true;

            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO tblEmployee (Name, Age, Gender, Salary, Department, TeamLead, IsCurrentEmployee) " +
                    "VALUES (@name, @age, @gender, @salary, @department, @teamLead, @isCurrentEmployee)", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age == 0 ? DBNull.Value : (object)age);
                cmd.Parameters.AddWithValue("@gender", string.IsNullOrEmpty(gender) ? DBNull.Value : (object)gender);
                cmd.Parameters.AddWithValue("@salary", salary == 0 ? DBNull.Value : (object)salary);
                cmd.Parameters.AddWithValue("@department", string.IsNullOrEmpty(department) ? DBNull.Value : (object)department);
                cmd.Parameters.AddWithValue("@teamLead", teamLead == null ? DBNull.Value : (object)teamLead);
                cmd.Parameters.AddWithValue("@isCurrentEmployee", isCurrentEmployee.HasValue ? (object)isCurrentEmployee.Value : DBNull.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee record inserted successfully!");
                con.Close();
                fncFillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                string query = "SELECT * FROM tblEmployee WHERE Name LIKE '%" + keyword + "%'";
                adapt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}