using System.Data;
using System.Data.SqlClient;

namespace colortable
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
            dt = new DataTable();
            fncFillGrid();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellClick += dataGridView1_CellClick;
            button1.Text = "Search";
        }
        public void fncFillGrid()
        {
            try
            {
                string connectionstring = "Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94";
                string sql = "SELECT * FROM tblDate WHERE Name LIKE '%" + textBox1.Text + "%' OR Age LIKE '%" + textBox1.Text + "%' OR DateofBirth LIKE '%" + textBox1.Text + "%'";
                con = new SqlConnection(connectionstring);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                con.Open();
                dataadapter.Fill(ds, "tblDate");
                con.Close();
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.Pink;
            }
            else
            {
                e.CellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
            }
        }
 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Purple;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fncFillGrid();
        }
    }
}