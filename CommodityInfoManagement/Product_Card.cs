using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Data;
using Tamir.SharpSsh;

namespace CommodityInfoManagement
{
          
    public partial class Product_Card : Form
    {
        public const int PUT_AWAY = 0, SHOW_INFO = 1;
        private bool isUpdate = true;
        private string oldName;
        private string infoCommand = "insert into comm_info values(" +
            "null, " + 
            "?name, " +
            "(select category_id from comm_category where category_name=?category_name), " +
            "(select user_id from comm_user where username=?username), " +
            "?image, " +
            "?length, " +
            "?width, " +
            "?height, " +
            "?weight," +
            "?color, " +
            "?shape, " +
            "?description);";
        private string stockCommand = "insert into comm_storage_rack values(" +
            "(select comm_id from comm_info where comm_name=?name)" +
            ", ?amount, " +
            "?price);";
        private string updateCommandA = "update comm_info set " +
            "comm_name=?name , " +
            "comm_category_id=(select category_id from comm_category where category_name=?category_name) , " +
            "comm_owner_id=(select user_id from comm_user where username=?username) , " +
            "comm_image=?image , " +
            "comm_length=?length , " +
            "comm_weight=?width , " +
            "comm_height=?height , " +
            "comm_weight=?weight , " +
            "comm_color=?color , " +
            "comm_shape=?shape , " +
            "comm_description=?description " +
            "where comm_name=?oldName;";
        private string updateCommandB = "update comm_storage_rack set " +
            "comm_stock_amount=?amount, " +
            "comm_unit_price=?price " +
            "where comm_id=(select comm_id from comm_info where comm_name=?name);";
        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlAdapter adapter = new MySqlAdapter())
                {
                    adapter.AddParams(new MySqlParameter("name", name.Text));
                    adapter.AddParams(new MySqlParameter("category_name", category.Text));
                    adapter.AddParams(new MySqlParameter("username", MainForm.GetInstance().GetUsername()));
                    Scp scp = new Scp("45.76.37.186", "commodity", "mxylls123!@#");
                    scp.Connect();
                    scp.To(imgPath.Text, "/home/commodity/CommodityInfo/Images/" + name.Text + ".jpg");
                    scp.Close();
                    adapter.AddParams(new MySqlParameter("image", name.Text + ".jpg"));
                    adapter.AddParams(new MySqlParameter("length", length.Text == "" ? null : length.Text));
                    adapter.AddParams(new MySqlParameter("width", width.Text == "" ? null : width.Text));
                    adapter.AddParams(new MySqlParameter("height", height.Text == "" ? null : height.Text));
                    adapter.AddParams(new MySqlParameter("weight", weight.Text == "" ? null : weight.Text));
                    adapter.AddParams(new MySqlParameter("color", color.Text == "" ? null : color.Text));
                    adapter.AddParams(new MySqlParameter("shape", shape.Text == "" ? null : shape.Text));
                    adapter.AddParams(new MySqlParameter("description", description.Text == "" ? null : description.Text));
                    adapter.AddParams(new MySqlParameter("amount", amount.Text));
                    adapter.AddParams(new MySqlParameter("price", price.Text));
                    if (isUpdate)
                    {
                        adapter.AddParams(new MySqlParameter("oldName", oldName));
                        adapter.ExecuteNonQuery(updateCommandA);
                        adapter.ExecuteNonQuery(updateCommandB);
                    }
                    else
                    {
                        adapter.ExecuteNonQuery(infoCommand);
                        adapter.ExecuteNonQuery(stockCommand);
                    }
                }
                MessageBox.Show((isUpdate?"更新":"上架")+"成功");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, (isUpdate ? "更新" : "上架") + "失败");
                throw exception;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFileDialog = new OpenFileDialog();
            chooseFileDialog.Multiselect = false;
            chooseFileDialog.Title = "请选择图片";
            chooseFileDialog.Filter = "JPEG图片(*.jpg,*.jpeg)|*.jpg;*.jpeg";
            if(chooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(chooseFileDialog.FileName).Length < 2097152)
                {
                    imgPath.Text = chooseFileDialog.FileName;
                    commImg.Image = Image.FromFile(imgPath.Text);
                }
                else
                {
                    MessageBox.Show("图片大小不可超过2M！");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public IEnumerable<Control> GetAllControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl))
                                      .Concat(controls);
        }

        public Product_Card()
        {
            InitializeComponent();
            isUpdate = false;
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                try
                {
                    var results = adapter.GetDataView("select category_name from comm_category;");
                    foreach (DataRow s in results.Table.Rows)
                    {
                        category.Items.Add(s["category_name"]);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, "分类信息数据获取失败！");
                }

            }
        }

        public Product_Card(Commodity commodity, string path, bool update=false)
        {
            InitializeComponent();
            if (!update)
            {
                isUpdate = false;
                var controls = GetAllControls(this);
                foreach (var c in controls)
                {
                    c.Enabled = false;
                }
                cancel.Enabled = true;
                cancel.Focus();
            }
            imgPath.Text = path;
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                try
                {
                    var results = adapter.GetDataView("select category_name from comm_category;");
                    foreach (DataRow s in results.Table.Rows)
                    {
                        category.Items.Add(s["category_name"]);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, "分类信息获取失败！");
                }

            }
            commodity.BindToProductCard(this);
            oldName = name.Text;
        }

        public void SetCommName(string s)
        {
            name.Text = s;
        }
        public void SetCommCategory(string s)
        {
            category.Text = s;
        }
        public void SetCommPrice(string s)
        {
            price.Text = s;
        }
        public void SetCommAmount(string s)
        {
            amount.Text = s;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetCommImage(Image img)
        {
            commImg.Image = img;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            commImg.Dispose();
            Dispose();
        }
    }
}