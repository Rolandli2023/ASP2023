using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace cstdemo1
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            loadUserInfo();
        }
        private void loadUserInfo()
        {
            List < UserInfo > userList(); 
            String connstr = ConfigurationManager.ConnectionStrings["strSql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "select * from userinfo where delflag=0";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserInfo userInfo = new UserInfo();
                            userInfo.UserName = reader["UserName"].ToString();
                            userInfo.UserAge = int.Parse(reader["UserAge"].ToString());
                            userInfo.UserEmail = reader["UserEmail"].ToString();
                            userInfo.UserMobile = reader["UserMobile"].ToString();

                            userList.Add(userInfo);
                        }
                    }
                }
            }
            this.dataGridView1.DataSource = userList;
        }
    }
}
