using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Show_Forms
{
    public partial class ShowSellBillItemsForm : Form
    {
        private int id;
        public ShowSellBillItemsForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ShowSellBillItemsForm_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT item_name as 'اسم الماده' ,item_count as 'عدد الماده' ,item_price as 'سعر الماده' FROM sell_bill_items WHERE sbill_id=" + id;
                DataSet data = new DataSet();
                new SqlConnectionDB().selectDB(ref data, query);
                sell_bill_items_gridview.DataSource = data.Tables[0];
            }
            catch
            {

            }
        }
    }
}
