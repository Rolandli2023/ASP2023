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

namespace cstDemo1
{

    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }


        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadUserInfos();
        }

        private void LoadUserInfos()

        {
            
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string sql = "Select * from Userinfo where DelFlag=0";
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //this.dgvUserInfo.DataSource = dt;
                List<UserInfo> userList = new List<UserInfo>();
                foreach (DataRow dataRow in dt.Rows)
                {

                    UserInfo userInfo = new UserInfo();
                    userInfo.UserID = int.Parse(dataRow["UserID"].ToString());
                    userInfo.UserName = dataRow["UserName"].ToString();
                    userInfo.UserAge = int.Parse(dataRow["UserAge"].ToString());
                    userInfo.UserEmail = dataRow["UserEmail"].ToString();
                    userInfo.UserMobile = dataRow["UserMobile"].ToString();
                    userInfo.DelFlag =short.Parse( dataRow["DelFlag"].ToString());
                    userList.Add(userInfo);
                        

                }
                this.dgvUserInfo.DataSource = userList;

            
                    
            }
        }
    }
}
