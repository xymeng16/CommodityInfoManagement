using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityInfoManagement
{
    static class Utility
    {
        public static void TestDBConnection()
        {
            using (MySqlAdapter adapter = new MySqlAdapter())
            {
                var result = adapter.GetDataView("show databases;");
                if(null == result)
                {
                    System.Windows.Forms.MessageBox.Show("Failed to connect to the database.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Connect to the database successfully.");
                }
            }
        }
    }
}
