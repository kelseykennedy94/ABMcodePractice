
using System.Data;
using System.Data.SqlClient;

namespace DOB
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94");
        SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable dt;
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Ascending";
            button2.Text = "Descending";
            button3.Text = "Ascending";
            button4.Text = "Descending";
            button5.Text = "Ascending";
            button6.Text = "Descending";

            label1.Text = "DOB";
            label2.Text = "Age";
            label3.Text = "Name";

            fncFillGrid();
        }

        public void fncFillGrid()
        {
            try
            {
                string connectionstring = "Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
                string sql = "SELECT * FROM tblDate";
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "tblDate");
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblDate ORDER BY DateofBirth ASC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblDate ORDER BY DateofBirth DESC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblDate ORDER BY Age ASC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblDate ORDER BY Age DESC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblDate ORDER BY Name ASC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblDate ORDER BY Name DESC", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}