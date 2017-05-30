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
    public partial class buy_num : Form
    {
        public buy_num()
        {
            InitializeComponent();
        }
        private int comm_num;
        private int comm_id;
        private string username;
        public void info(int num,int id,string user) {
            num_remind.Text = "请输入购买数量：0到"+num;
            comm_num = num;
            comm_id = id;
            username = user;
        }

        private void num_comfirm_Click(object sender, EventArgs e)
        {
            int buy_num = int.Parse(buycomm_num.Text.Trim());
            if (buy_num <= 0 || buy_num > comm_num)
            {
                MessageBox.Show("请输入0到" + comm_num + "之间的一个数");
            }
            else
            {
                using (MySqlAdapter adapter = new MySqlAdapter()) {
                    string sqlcommand1 = "update comm_storage_rack set comm_stock_amount = comm_stock_amount - " + buy_num +
                                        " where comm_id = " + comm_id;
                    adapter.ExecuteNonQuery(sqlcommand1);
                    string sqlcommand2 = "select user_id from comm_user where username = '" + username +"'";
                    DataRow dr = adapter.GetDataRow(sqlcommand2);
                    int user_id = Convert.ToInt32(dr[0]);
                    string sqlcommand3 = "insert into comm_purchasing_log value('NULL'," + comm_id + "," + user_id + "," + buy_num + ")";
                    adapter.ExecuteNonQuery(sqlcommand3);
                    MessageBox.Show("购买成功！");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
