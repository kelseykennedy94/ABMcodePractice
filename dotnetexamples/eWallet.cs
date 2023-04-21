using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wallet
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
            button1.Text = "Submit";
            LoadTotalMoney();
        }
        private void LoadTotalMoney()
        {
            string sql = "SELECT SUM(TotalMoney) FROM tblEWallet";
            cmd = new SqlCommand(sql, con);
            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result != DBNull.Value)
            {
                label1.Text = Convert.ToDecimal(result).ToString("C");
            }
            else
            {
                label1.Text = "$0.00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter an amount.");
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            try
            {
                char debitCredit = amount >= 0 ? 'C' : 'D';

                if (debitCredit == 'D')
                {
                    string sql = "SELECT SUM(TotalMoney) FROM tblEWallet";
                    cmd = new SqlCommand(sql, con);
                    con.Open();
                    object objresult = cmd.ExecuteScalar();
                    con.Close();

                    decimal currentBalance = objresult != DBNull.Value ? Convert.ToDecimal(objresult) : 0;
                    if (currentBalance == 0)
                    {
                        MessageBox.Show("Cannot withdraw when the current balance is 0.");
                        return;
                    }
                    else if (Math.Abs(amount) > currentBalance)
                    {
                        MessageBox.Show("Insufficient funds.");
                        return;
                    }
                }

                string insertSql = "INSERT INTO tblEWallet (TotalMoney, TransactionType, MoneyInsertDate) VALUES (@TotalMoney, @TransactionType, @MoneyInsertDate)";
                cmd = new SqlCommand(insertSql, con);
                cmd.Parameters.AddWithValue("@TotalMoney", Math.Abs(amount) * (debitCredit == 'C' ? 1 : -1));
                cmd.Parameters.AddWithValue("@TransactionType", debitCredit);
                cmd.Parameters.AddWithValue("@MoneyInsertDate", DateTime.Now);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    LoadTotalMoney();
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data: " + ex.Message);
            }
        }
    }
}