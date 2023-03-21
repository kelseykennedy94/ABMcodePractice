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

namespace userandpass
{
    public partial class Form2 : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;

        public Form2()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-G10UINRH;Initial Catalog=Demodb;User ID=sa;Password=kelsey94");
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Username:";
            label2.Text = "New Password:";
            label3.Text = "Confirm:";
            button1.Text = "Update";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string newPassword = textBox2.Text.Trim().ToString();
            string confirm = textBox3.Text.Trim().ToString();

            if (username != "" && newPassword != "" && confirm != "")
            {
                updatePassword(username, newPassword, confirm);
            }
        }

        public void updatePassword(string username, string newPassword, string confirm)
        {
            if (username != "" && newPassword != "" && confirm != "")
            {
                cmd = new SqlCommand("update tblusername set username=@username,password=@password where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", confirm);
                cmd.Parameters.AddWithValue("@id", 1);
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Record not updated successfully.");
                }
            }
        }
    }
}