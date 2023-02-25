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

namespace demo1
{
    public partial class MainFrm : Form
    {
        private int updateUserID = 0;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            loadUserInfo();
        }
        #region loadUserInfo
        private void loadUserInfo()
        {
            List<UserInfo> userList = new List<UserInfo>();
            String connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
           
             String sql = "select * from UserInfo where DelFlag=0";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //this.dgvUserList.DataSource = dt;

                    
                   

                    foreach (DataRow dataRow in dt.Rows)
                    {
                         UserInfo userInfo = new UserInfo();
                         userInfo.UserID = int.Parse(dataRow["UserID"].ToString());
                         userInfo.UserName = dataRow["UserName"].ToString();
                         userInfo.UserAge = int.Parse(dataRow["UserAge"].ToString());
                         userInfo.UserEmail = dataRow["UserEmail"].ToString();
                         userInfo.UserMobile = dataRow["UserMobile"].ToString();
                         userInfo.DelFlag = short.Parse(dataRow["DelFlag"].ToString());

                         userList.Add(userInfo);

                    }
                    this.dgvUserList.DataSource = userList;
                }
            
               
        }
        #endregion
        #region delete one record by userID

        private void btnDelect_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("data deleted");
           if (this.dgvUserList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("please select all least one row");
            }

            int deleteUserID = int.Parse(this.dgvUserList.SelectedRows[0].Cells["UserID"].Value.ToString());
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = "delete from UserInfo where UserID=@UserID";
                    cmd.CommandText = "UPDATE dbo.UserInfo set DelFlag=1 where USerID=@UserID";
                    cmd.Parameters.AddWithValue("@UserID", deleteUserID);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("record deleted successfully!");
                    }
                    loadUserInfo();
                }
            }
        }
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserInfoAddFrm userInfoAddFrm= new UserInfoAddFrm();

            userInfoAddFrm.Show();
        }
        #region

        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("data selected!");
            if (this.dgvUserList.SelectedRows.Count <= 0)
            {
                return;
            }
            //MessageBox.Show(this.dgvUserList.SelectedRows[0].Cells[0].Value.ToString());

            int selectRowID=int.Parse(this.dgvUserList.SelectedRows[0].Cells[0].Value.ToString());

            updateUserID = selectRowID;

            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "select UserName,UserAge,UserEmail,UserMobile from dbo.userInfo where UserID=@UserID";
                    cmd.Parameters.AddWithValue("@UserID", selectRowID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.txtUserName.Text = reader["UserName"].ToString();
                            this.txtUserAge.Text = reader["UserAge"].ToString();
                            this.txtUserEmail.Text = reader["UserEmail"].ToString();
                            this.txtUserMobile.Text = reader["UserMobile"].ToString();

                        }
                    }
                }
            }
            #endregion
            //read one record to database
        }
        #region save record

        private void bntSave_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update UserInfo set UserName=@UserName,UserAge=@UserAge,UserEmail=@UserEmail,UserMobile=@UserMobile where UserID=@UserID";
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@UserAge", txtUserAge.Text);
                    cmd.Parameters.AddWithValue("@UserEmail", txtUserEmail.Text);
                    cmd.Parameters.AddWithValue("@UserMobile", txtUserMobile.Text);
                    cmd.Parameters.AddWithValue("@UserID", updateUserID);
                    int nums =  cmd.ExecuteNonQuery();

                    if (nums > 0)
                    {
                        MessageBox.Show("record saved");
                    }else
                    {
                        MessageBox.Show("record saved failure");
                    }
                    loadUserInfo();

                }
            }
        }
        #endregion

        #region  search data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // create one static method for sql connection string
            string connStr = SqlHelper.GetSqlconnectionString();
            //dataAdapter read record
            string sqlTxt = "select * from UserInfo";
            List<string> whereList = new List<string>();
            List<SqlParameter> parameters = new List<SqlParameter>();  // declare paramers list
            if (!string.IsNullOrEmpty(this.txtSearchUserName.Text.Trim()))
            {
                //add condition username to wherList
                whereList.Add(" UserName Like @UserName ");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.Value = "%" + txtSearchUserName.Text + "%";
                parameters.Add(parameter);
            }

            if (!string.IsNullOrEmpty(this.txtSearchUserEmail.Text.Trim()))
            {
                whereList.Add("UserEmail Like @UserEmail");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserEmail";
                parameter.Value = "%" + txtSearchUserEmail.Text + "%";
                parameters.Add(parameter);

            }

            if (!string.IsNullOrEmpty(this.txtSearchUserMobile.Text.Trim()))
            {
                whereList.Add("UserMobile Like @UserMobile");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserMobile";
                parameter.Value = "%" + txtSearchUserMobile.Text + "%";
                parameters.Add(parameter);

            }

            if (whereList.Count > 0)
            {
                sqlTxt += " where " + string.Join(" and ", whereList);

            }

            List<UserInfo> userList = new List<UserInfo>();

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlTxt, connStr))
            {
                adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //this.dgvUserList.DataSource = dt;
                foreach (DataRow dataRow in dt.Rows)
                {
                    UserInfo userInfo = new UserInfo();
                    userInfo.UserID = int.Parse( dataRow["UserID"].ToString());
                    userInfo.UserName = dataRow["UserName"].ToString();
                    userInfo.UserEmail = dataRow["UserEmail"].ToString();
                    userInfo.UserMobile = dataRow["UserMobile"].ToString();
                    userInfo.UserAge = int.Parse(dataRow["UserAge"].ToString());
                    userInfo.DelFlag = short.Parse(dataRow["DelFlag"].ToString());

                    userList.Add(userInfo);

                }
                this.dgvUserList.DataSource = userList;
            }
            #endregion

        }
    }
}
