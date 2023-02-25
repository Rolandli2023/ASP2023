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

namespace damo2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();

        }

        private void LoadUserInfo()
        {
            //MessageBox.Show("loading");
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string strSql= "slect* From UserInfo where DelFlag=0";
                using (SqlDataAdapter adapter = new SqlDataAdapter(strSql,conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //this.dgvUserList.DataSource = dt;
                    List<UserInfo> userList = new List<UserInfo>();
                    UserInfo userInfo = new UserInfo();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        userInfo.UserID = int.Parse(dataRow["UserId"].ToString());
                        userInfo.UserName = dataRow["UserName"].ToString();
                        userInfo.UserEmail = dataRow["UserEmail"].ToString();
                        userInfo.UserMobile = dataRow["UserMobile"].ToString();
                        userList.Add(userInfo);

                    }
                    this.dgvUserList.DataSource = userList;

                }
                //this.dgvUserList.DataSource = dt;
                //using (SqlCommand cmd = conn.CreateCommand())
                //{
                //    conn.Open();
                //    cmd.CommandText = "slect* From UserInfo where DelFlag=0";
                //    using (SqlDataAdapter adapter = new SqlDataAdapter())
                //    {

                    //    }
                    //}
            }
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
