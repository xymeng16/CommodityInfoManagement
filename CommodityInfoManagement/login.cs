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

        private void button_signup_Click(object sender, EventArgs e)
        {
            string sqlCommand = String.Format("insert into comm_user values(null, '{0}', sha1('{1}'), now());" +
                    "insert into comm_user_role values((select user_id from comm_user where username='{0}'), (select role_id from comm_role where role_name='{2}'));",
                    username.Text, password.Text, Login.RoleStr["消费者"]);
            try
            {
                using (MySqlAdapter adapter = new MySqlAdapter())
                {
                    adapter.ExecuteNonQuery(sqlCommand);
                }
                MessageBox.Show("注册成功！您的当前身份为：顾客！", "注册成功");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,  "注册失败");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
                System.Environment.Exit(0);
        }

    }
}
