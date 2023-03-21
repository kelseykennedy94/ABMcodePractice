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
            label2.Text = "Password:";
            button1.Text = "Login";
            button2.Text = "Forgot Password?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();

            bool isLoginResult = fncLogin(username, password);
            if (isLoginResult == true)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }

        public bool fncLogin(string username, string password)
        {
            bool isLoginResult = false;
            try
            {
                cmd = new SqlCommand("insert into tblUsername(Username, Password, isActive) values(@username,@password,@isActive)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@isActive", true);
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Record inserted successfully.");
                    isLoginResult = true;
                }
                else
                {
                    MessageBox.Show("Record not inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return isLoginResult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        }
    }
