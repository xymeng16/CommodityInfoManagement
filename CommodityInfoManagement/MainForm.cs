using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tamir.SharpSsh;

namespace CommodityInfoManagement
{
    public partial class MainForm : Form
    {
        private static User currentUser;
        private DataView dv;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            comm_search_category.Items.Add("a");
            comm_search_category.Items.Add("b");
            comm_search_category.Items.Add("c");
            comm_search_category.Items.Add("d");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static string GetUsername()
        {
            return currentUser.Username;
        }
        public static User GetCurrentUser()
        {
            return currentUser;
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
            (new Product_Card()).Show();
        }

        private void comm_search_Click(object sender, EventArgs e)
        {
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                string comm_name = comm_search_text.Text.Trim();
                string comm_category = comm_search_category.Text.Trim();
                if (string.Compare(comm_category, "选择商品类别...") == 0) { comm_category = ""; }
                string sqlcommand = "select comm_name as name,category_name,comm_unit_price,comm_stock_amount from comm_info,comm_category,comm_storage_rack " +
                                    "where comm_name like '%" + comm_name + "%' and comm_name like '%" + comm_category + "%' and " + 
                                    "comm_info.comm_id = comm_storage_rack.comm_id and comm_info.comm_category_id = comm_category.category_id ";
                dv = adapter.GetDataView(sqlcommand);
                this.search_result.DataSource = dv;
                // this.search_result.DataSource = adapter.GetDataView(sqlcommand);
                this.search_result.Columns[0].HeaderCell.Value = "名称";
                this.search_result.Columns[1].HeaderCell.Value = "分类";
                this.search_result.Columns[2].HeaderCell.Value = "单价";
                this.search_result.Columns[3].HeaderCell.Value = "库存";
            }
        }

        private void filter_Click_1(object sender, EventArgs e)
        {
            float lp = float.Parse(low_price.Text.Trim());
            float hp = float.Parse(high_price.Text.Trim());
            float la = float.Parse(low_amount.Text.Trim());
            float ha = float.Parse(high_amount.Text.Trim());
            if ((hp == 0 && ha == 0) || (lp > hp) || (la > ha))
            {
                MessageBox.Show("输入错误，请检查！");
            }
            if (hp == 0 && ha != 0)
            {
                using (MySqlAdapter adapter = new MySqlAdapter())
                {
                    dv.RowFilter = "comm_stock_amount >= " + la + " and comm_stock_amount <= " + ha;
                    this.search_result.DataSource = dv;
                    this.search_result.Columns[0].HeaderCell.Value = "名称";
                    this.search_result.Columns[1].HeaderCell.Value = "分类";
                    this.search_result.Columns[2].HeaderCell.Value = "单价";
                    this.search_result.Columns[3].HeaderCell.Value = "库存";
                }
            }
            if (ha == 0 && hp != 0)
            {
                using (MySqlAdapter adapter = new MySqlAdapter())
                {
                    dv.RowFilter = "comm_unit_price >= " + lp + " and comm_unit_price <= " + hp;
                    this.search_result.DataSource = dv;
                    this.search_result.Columns[0].HeaderCell.Value = "名称";
                    this.search_result.Columns[1].HeaderCell.Value = "分类";
                    this.search_result.Columns[2].HeaderCell.Value = "单价";
                    this.search_result.Columns[3].HeaderCell.Value = "库存";
                }
            }
            if (hp != 0 && ha != 0)
            {
                using (MySqlAdapter adapter = new MySqlAdapter())
                {
                    dv.RowFilter = "comm_stock_amount >= " + la + " and comm_stock_amount <= " + ha + " and comm_unit_price >= " + lp + " and comm_unit_price <= " + hp;
                    this.search_result.DataSource = dv;
                    this.search_result.Columns[0].HeaderCell.Value = "名称";
                    this.search_result.Columns[1].HeaderCell.Value = "分类";
                    this.search_result.Columns[2].HeaderCell.Value = "单价";
                    this.search_result.Columns[3].HeaderCell.Value = "库存";
                }
            }
        }

        private void low_price_MouseClick(object sender, MouseEventArgs e)
        {
            low_price.Text = "";
        }

        private void high_price_MouseClick(object sender, MouseEventArgs e)
        {
            high_price.Text = "";
        }

        private void low_amount_MouseClick(object sender, MouseEventArgs e)
        {
            low_amount.Text = "";
        }

        private void high_amount_MouseClick(object sender, MouseEventArgs e)
        {
            high_amount.Text = "";
        }

        private void low_price_Leave(object sender, EventArgs e)
        {
            if (low_price.Text.Trim() == "")
                low_price.Text = "0";
        }

        private void high_price_Leave(object sender, EventArgs e)
        {
            if (high_price.Text.Trim() == "")
                high_price.Text = "0";
        }

        private void low_amount_Leave(object sender, EventArgs e)
        {
            if (low_amount.Text.Trim() == "")
                low_amount.Text = "0";
        }

        private void high_amount_Leave(object sender, EventArgs e)
        {
            if (high_amount.Text.Trim() == "")
                high_amount.Text = "0";
        }

        private void detail_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlAdapter adapter = new MySqlAdapter())
                {
                    string name = (string)search_result.CurrentRow.Cells[0].Value;
                    adapter.AddParams(new MySql.Data.MySqlClient.MySqlParameter("name", name));
                    var result = adapter.GetDataRow("select comm_name, category_name, comm_unit_price," +
                        " comm_stock_amount, username from comm_info," +
                        "comm_category, comm_storage_rack, comm_user " +
                        "where comm_name=?name and user_id=comm_owner_id " +
                        "and category_id=comm_category_id and comm_storage_rack.comm_id=comm_info.comm_id");
                    Scp scp = new Scp("45.76.37.186", "commodity", "mxylls123!@#");
                    scp.Connect();
                    if (!Directory.Exists(System.Environment.CurrentDirectory + "\\temp"))
                    {
                        Directory.CreateDirectory(System.Environment.CurrentDirectory + "\\temp");
                    }
                    scp.From("/home/commodity/CommodityInfo/Images/" + name + ".jpg", System.Environment.CurrentDirectory + "\\" + name + ".jpg");
                    scp.Close();
                    (new Product_Card(new Commodity(result["comm_name"] as string, result["category_name"]
                        as string, result["username"] as string,
                        Image.FromFile(System.Environment.CurrentDirectory + "\\" + name + ".jpg"),
                        Convert.ToString(result["comm_unit_price"]), Convert.ToString(result["comm_stock_amount"])))).Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "数据获取失败！");
            }
        }

        private void userManagement_Click(object sender, EventArgs e)
        {
            (new UserManagement()).ShowDialog();
        }
    }
}
