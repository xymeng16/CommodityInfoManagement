using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommodityInfoManagement
{
    public partial class Login : Form
    {
        public static Login self;
        public static NameValueCollection RoleStr = new NameValueCollection();
        private bool firstTime = true;
        public Login()
        {
            InitializeComponent();
            self = this;
            password.UseSystemPasswordChar = true;
            password.MaxLength = 16;
            RoleStr.Add("消费者", "CUSTOMER");
            RoleStr.Add("卖家", "SHOPKEEPER");
            RoleStr.Add("管理员", "ADMIN");
            RoleStr.Add("超级管理员", "SUPER_USER");
            RoleStr.Add("CUSTOMER", "消费者");
            RoleStr.Add("SHOPKEEPER", "卖家");
            RoleStr.Add("ADMIN", "管理员");
            RoleStr.Add("SUPER_USER", "超级管理员");
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                string sqlCommand = "select username,role_name, create_time  from comm_user, comm_user_role, " +
                    "comm_role where username=?usr and password=sha1(?pwd) and " +
                    "comm_user_role.user_id=comm_user.user_id and comm_role.role_id=comm_user_role.role_id";
                adapter.AddParams(new MySql.Data.MySqlClient.MySqlParameter("usr", username.Text));
                adapter.AddParams(new MySql.Data.MySqlClient.MySqlParameter("pwd", password.Text));
                var row = adapter.GetDataRow(sqlCommand);
                if(row != null)
                {

                    MainForm.GetInstance().SetCurrentUser(new User((string)row["username"], RoleStr[(string)row["role_name"]].Split(',')[0], (DateTime)row["create_time"]));
                    if(firstTime == true)
                    {
                        firstTime = false;
                    }
                    else
                    {
                        MainForm.GetInstance().Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！请重新输入！");
                }
            }
        }
    }
}
