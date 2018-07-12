using Dental_Lab.Classes;
using Dental_Lab.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Main_Forms
{
    public partial class AddSellBillForm : Form
    {
        private SqlConnectionDB db;
        private MainForm form;
        private string[,] data = new string[1,1];
        public void SetList(string[,] data)
        {
            this.data = data;
            items.Text = "تعديل الاغراض";
            double price = 0;
            for (int i = 0; i < data.GetLength(0); i++)
                price += Convert.ToDouble(data[i,2])*Convert.ToInt32(data[i,1]);
            price_txt.Text = price.ToString();
        }
        
        public AddSellBillForm(MainForm form)
        {
            InitializeComponent();
            db = new SqlConnectionDB();
            this.form = form;
            foreach (string s in db.ListOF("SELECT sell_name from seller"))
                seller_combo.Items.Add(s);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void items_Click(object sender, EventArgs e)
        {
            new SellBillItemsDialog(this).Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (seller_combo.SelectedItem.ToString() != "" && data != null)
            {
                int seller_id = db.SelectID("SELECT sell_id FROM seller WHERE sell_name='" + seller_combo.SelectedItem + "'");
                string insert_query1 = "INSERT INTO sell_bill (sell_id,sbill_price) VALUES(" + seller_id + "," + price_txt.Text + ")";
                if (db.insertDB(insert_query1))
                {
                    int real_id = Convert.ToInt32(db.ListOF("SELECT sbill_id FROM sell_bill").Last());
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        string insert_query2 = "INSERT INTO sell_bill_items VALUES('" + real_id + "','" + data[i, 0] + "','" + data[i, 1] + "','" + data[i, 2] + "')";
                        db.insertDB(insert_query2);
                    }
                    MessageBox.Show("تم اضافه الفاتوره");
                    this.Close();
                    form.RefreshSellBill(form.sell_bill_query);
                }
            }
        }
        
    }
}
