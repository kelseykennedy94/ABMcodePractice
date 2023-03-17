using System.Data;
using System.Data.SqlClient;

namespace databaseconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDropdown();
        }

        public void fillDropdown()
        {
            using(SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94"))
            {
                try
                {
                    string query = "select ID,Description,isActive from tblArea";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblArea");
                    comboBox1.DisplayMember = "Description";
                    comboBox1.ValueMember = "ID";
                    comboBox1.DataSource = ds.Tables["tblArea"];
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Occured");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string connectionString;
            SqlConnection cn;
            connectionString = @"Data Source = LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            cn = new SqlConnection(connectionString);
            cn.Open();
            MessageBox.Show("Connection has been opened");
            cn.Close();*/
        }
    }
}