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
    public partial class UserInfo : Form
    {
        public UserInfo(User user)
        {
            InitializeComponent();
            username.Text = user.Username;
            createTime.Text = user.Datetime.ToString();
            role.Text = user.Role;
        }
    }
}
