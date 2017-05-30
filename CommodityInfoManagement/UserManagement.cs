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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            RefreshUserList();
        }
        private void RefreshUserList()
        {
            string sqlCommand = "select username, role_name, " +
                "create_time from comm_user, comm_user_role, comm_role" +
                " where comm_user.user_id=comm_user_role.user_id and " +
                "comm_role.role_id=comm_user_role.role_id;";
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                var result = adapter.GetDataView(sqlCommand);
                userList.DataSource = result;
                userList.Columns[0].HeaderCell.Value = "用户名";
                userList.Columns[1].HeaderCell.Value = "角色";
                userList.Columns[2].HeaderCell.Value = "创建时间";
            }
            userList.Refresh();
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            (new ModifyUser(null)).ShowDialog();
            RefreshUserList();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            (new ModifyUser(new User(userList.CurrentRow.Cells[0].Value as string, User.RoleStr[userList.CurrentRow.Cells[1].Value as string], (DateTime)userList.CurrentRow.Cells[2].Value))).ShowDialog();
            RefreshUserList();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            string sqlCommand = "delete from comm_user_role where user_id=(select user_id from comm_user where username='"+ 
                userList.CurrentRow.Cells[0].Value as string+"');" +
                "delete from comm_user where username='" + userList.CurrentRow.Cells[0].Value as string + "';";
            try
            {
                using (MySqlAdapter adapter = new MySqlAdapter())
                {
                    adapter.ExecuteNonQuery(sqlCommand);
                }
                MessageBox.Show("删除成功！");
                RefreshUserList();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message ,"删除失败！");
            }
            
        }
    }
}
