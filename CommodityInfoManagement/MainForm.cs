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
    public partial class MainForm : Form
    {
        private User currentUser;
        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            comboBox1.Items.Add("ALL");
            comboBox1.Items.Add("GOODS A");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myInfo_Click(object sender, EventArgs e)
        {
            (new UserInfo(currentUser)).Show();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Login.self.Show();
            this.Close();
        }

        private void putAway_Click(object sender, EventArgs e)
        {
            (new Product_Card(Product_Card.PUT_AWAY)).Show();
        }
    }
}
