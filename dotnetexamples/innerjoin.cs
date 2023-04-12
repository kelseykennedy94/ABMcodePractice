using System.Data;
using System.Data.SqlClient;

namespace innerjoin
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        private DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fncFillGrid();
            button1.Text = "Male";
            button2.Text = "Female";
        }
        public void fncFillGrid()
        {
            string connectionstring = "Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
            string sql = "SELECT tblOne.EmployeeID, tblOne.FirstName, tblOne.LastName, tblOne.Gender, tblTwo.Name " +
                         "FROM tblOne " +
                         "INNER JOIN tblTwo ON tblOne.EmployeeID = tblTwo.StoreID";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = "Gender = 'M'";
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = "Gender = 'F'";
            dataGridView1.DataSource = dv;
        }
    }
}