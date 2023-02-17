using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Username or Password is empty!");
            }
            string connStr = "server=192.168.2.253;uid=sa;pwd=Allen2013;database=market";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"select count(*) from UserInfo where UserName='" + txtUserName.Text + "'  and UserPassword= '" + txtPassword.Text + "' ";
                    //'"+txtUserName.Text+"'
                    //    '"+txtPwd.Text+"'

                    object result = cmd.ExecuteScalar();
                    int rows = int.Parse(result.ToString());
                    if (rows >= 1)
                    {
                        MessageBox.Show("Login in successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is invalid");
                    }
                }
            }
        }
    }
}
