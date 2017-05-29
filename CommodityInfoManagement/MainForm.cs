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
            comm_search_category.Items.Add("ALL");
            comm_search_category.Items.Add("GOODS A");
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

        private void comm_search_Click(object sender, EventArgs e)
        {
            using (MySqlAdapter adapter = new MySqlAdapter()) { 
                string comm_name = comm_search_text.Text.Trim();
                string sqlcommand = "select comm_name,caterogy_name,comm_unit_price,comm_stock_amount from comm_info,comm_category,comm_storage_rack " +
                                    "where comm_name like '%" + comm_name + "%' and comm_info.comm_id = comm_storage_rack.comm_id " +
                                    "and comm_info.comm_category_id = comm_category.category_id";
                this.search_result.DataSource = adapter.GetDataView(sqlcommand);
            }
        }
    }
}
