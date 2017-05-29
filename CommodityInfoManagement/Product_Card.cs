using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CommodityInfoManagement
{
    public partial class Product_Card : Form
    {
        public const int PUT_AWAY = 0, SHOW_INFO = 1;

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

        private void submit_Click(object sender, EventArgs e)
        {
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
               // string infoCommand = "insert into comm_info values(null, " +
                //    "?name, ?category_id, ?owner_id, )"
            }
        }

        public Product_Card(int mode)
        {
            InitializeComponent();
        }
    }
}
