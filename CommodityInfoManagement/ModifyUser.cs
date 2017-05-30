using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommodityInfoManagement
{
    public partial class ModifyUser : Form
    {
        private bool isAdd;
        public ModifyUser(User user)
        {
            InitializeComponent();
            if(user != null)
            {
                isAdd = false;
                Text = "修改用户";
                username.Text = user.Username;
                username.Enabled = false;
                password.Enabled = false;
                category.Items.AddRange(new string[] { "消费者", "卖家" });
                if(user.Role == "超级管理员")
                {
                    category.Items.Add("管理员");
                }
            }
            else
            {
                isAdd = true;
                Text = "添加用户";
                category.Items.AddRange(new string[] { "消费者", "卖家" });
                if (user.Role == "超级管理员")
                {
                    category.Items.Add("管理员");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlCommand;
            if(isAdd)
            {
                sqlCommand = String.Format("insert into comm_user values(null, '{1}', sha1('{2}'), now());", 
                    username.Text, password.Text, User.RoleStr[category.Text]);
            }
            else
            {
                sqlCommand = String.Format("update comm_user_role set role_id=(select role_id from comm_role" +
                    " where role_name='{1}') where user_id=(select user_id from comm_user where username" +
                    "={2});", User.RoleStr[category.Text], username.Text);
            }
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                adapter.ExecuteNonQuery(sqlCommand);
            }
            MessageBox.Show("用户" + (isAdd ? "添加" : "修改") + "成功！");
        }
    }
}
