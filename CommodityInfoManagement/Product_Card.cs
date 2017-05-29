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
            "(select comm_id from comm_info where comm_name='?name')" +
            ", ?amount, " +
            "?price);";
        private void submit_Click(object sender, EventArgs e)
        {
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                adapter.AddParams(new MySqlParameter("name", name.Text));
                adapter.AddParams(new MySqlParameter("category_name", category.Text));
                adapter.AddParams(new MySqlParameter("username", MainForm.GetUsername()));
                Scp scp = new Scp("45.76.37.186", "commodity", "mxylls123!@#");
                scp.Connect();
                scp.To(imgPath.Text, "/home/commodity/CommodityInfo/Images/" + name.Text + ".jpg");
                scp.Close();
                adapter.AddParams(new MySqlParameter("image", name.Text+".jpg"));
                adapter.AddParams(new MySqlParameter("length", length.Text == "" ? null : length.Text));
                adapter.AddParams(new MySqlParameter("width", width.Text == "" ? null : width.Text));
                adapter.AddParams(new MySqlParameter("height", height.Text == "" ? null : height.Text));
                adapter.AddParams(new MySqlParameter("weight", weight.Text == "" ? null : weight.Text));
                adapter.AddParams(new MySqlParameter("color", color.Text == "" ? null : color.Text));
                adapter.AddParams(new MySqlParameter("shape", shape.Text == "" ? null : shape.Text));
                adapter.AddParams(new MySqlParameter("description", description.Text == "" ? null : description.Text));
                adapter.AddParams(new MySqlParameter("amount", amount.Text));
                adapter.AddParams(new MySqlParameter("price", price.Text));
                adapter.ExecuteNonQuery(infoCommand);
                adapter.AddParams(new MySqlParameter("name", name.Text));
                adapter.ExecuteNonQuery(stockCommand);
            }
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFileDialog = new OpenFileDialog();
            chooseFileDialog.Multiselect = false;
            chooseFileDialog.Title = "请选择图片";
            chooseFileDialog.Filter = "JPEG图片(*.jpg,*.jpeg)|*.jpg;*.jpeg";
            if(chooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPath.Text = chooseFileDialog.FileName;
            }
            commImg.Image = Image.FromFile(imgPath.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Product_Card(int mode)
        {
            InitializeComponent();
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                var results = adapter.GetDataView("select category_name from comm_category;");
                foreach (DataRow s in results.Table.Rows)
                {
                    category.Items.Add(s["category_name"]);
                }
            }
        }
    }
}
