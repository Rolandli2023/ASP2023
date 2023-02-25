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

namespace WindowsFormsApp1
{
    public partial class Userlist : Form
    {
        public Userlist()
        {
            InitializeComponent();
        }

        private void Userlist_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("data loading");
            loadUserInfo();
        }

        private void loadUserInfo()
        {
            
            String connstr = ConfigurationManager.ConnectionStrings["strSql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    List<UserInfo> userList = new List<UserInfo>();
                    UserInfo userInfo = new UserInfo();

                    foreach(DataRow dataRow in dt.Rows)

                    {
                        
                            
                            userInfo.UserID = int.Parse(dataRow["UserID"].ToString());
                            userInfo.UserName = dataRow["UserName"].ToString();
                            userInfo.UserEmail = dataRow["UserEmail"].ToString();
                            userInfo.UserMobile = dataRow["UserMobile"].ToString();

                            userList.Add(userInfo);
                             this.dgvUserlist.DataSource = userList;

                        //end while loop
                    }// end datareader
                }//end sqlcommond
            }// end connection
           
        }

       private void dgvUserlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }
    }
}
