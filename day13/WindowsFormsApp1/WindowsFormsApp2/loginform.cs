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
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // local server 127.0.0.1
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) || (string.IsNullOrEmpty(textBox2.Text.Trim())))
            {
                MessageBox.Show("Username or Password is empty.please check");
                return;
            }
            // connect to database, read username and password from database.
            //string connStr = "server=192.168.2.253;udi=as;pwd=Allen2013;database=Market";
            string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"select count(*) from UserInfo where UserName='"+textBox1.Text+"' and UserPassword='"+textBox2.Text+"'";
                    object result = cmd.ExecuteScalar();
                    int rows = int.Parse(result.ToString());
                    if (rows >= 1)
                    {
                        MessageBox.Show("Login successfully!");
                    }
                    else
                    {
                        MessageBox.Show("username or password error");
                    }
                }
            }
        }
    }
}
