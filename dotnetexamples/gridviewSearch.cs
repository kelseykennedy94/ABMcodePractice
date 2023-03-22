using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace userandpass
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
            label1.Text = "Username:";
            button1.Text = "Search";


            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Check";
            chk.Name = "chk";
            dataGridView1.Columns.Insert(0, chk);

            fncFillGrid();
        }

        public void fncFillGrid()
        {
            string connectionstring = "Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string sql = "SELECT * FROM tblUsername";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tblUsername");
            connection.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                string query = "SELECT * FROM tblUsername WHERE Username LIKE '%" + keyword + "%'";
                adapt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}