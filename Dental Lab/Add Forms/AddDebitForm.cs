using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Add_Forms
{
    public partial class AddDebitForm : Form
    {
        private SqlConnectionDB db;
        private DateTime date;
        private MainForm form;
        public AddDebitForm(MainForm form)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            db = new SqlConnectionDB();
            date = DateTime.Today;
            this.form = form;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_debit_btn_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            int n;
            if (customer_combo.SelectedIndex >= 0 && int.TryParse(price_text.Text, out n)) {
                string query = "INSERT INTO debits (cust_id,deb_date,deb_price,user_id) VALUES((SELECT cust_id from customer where cust_name='" + customer_combo.SelectedItem + "'),'" + FormatDate(date) + "','" + price_text.Text + "','" + form.Id + "')";
                if (db.insertDB(query))
                {
                    MessageBox.Show("تم اضافه الدين");
                    this.Close();
                }
            }
        }
        private string FormatDate(DateTime date)
        {
            string year = date.Year + "";
            string month = "";
            if (date.Month >= 10)
                month = date.Month + "";
            else month = "0" + date.Month;
            string day = date.Day + "";
            return year + "-" + month + "-" + day;
        }

        private void cust_type_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cust_type_combo.SelectedIndex >= 0)
            {
                customer_combo.Items.Clear();
                customer_label.Text = "اسم ال" + cust_type_combo.SelectedItem.ToString();
                string select = "SELECT cust_name from customer where cust_type='" + cust_type_combo.SelectedItem.ToString() + "'";
                foreach (string s in db.ListOF(select))
                    customer_combo.Items.Add(s);
            }
        }
    }
}
