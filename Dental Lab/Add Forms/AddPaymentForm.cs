using Dental_Lab.Classes;
using Dental_Lab.Show_Forms;
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
    public partial class AddPaymentForm : Form
    {
        private SqlConnectionDB db;
        private Check_Class ch = null;
        private MainForm form;
        private ShowCustBills cust_form;
        private DateTime date;
        public AddPaymentForm(MainForm form)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            db = new SqlConnectionDB();
            this.form = form;
            date = DateTime.Today;
        }
        public AddPaymentForm(ShowCustBills cust_form,DateTime date)
        {
            this.cust_form = cust_form;
            this.date = date;
        }
        private void AddPaymentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void add_check_btn_Click(object sender, EventArgs e)
        {
            new AddCheckForm(this, ch).Show();
        }
        public void SetCheck(Check_Class checks)
        {
            ch = checks;
        }

        private void add_payment_btn_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            int n;
            if (customer_combo.SelectedIndex >= 0 && int.TryParse(price_text.Text, out n))
            {
                String query = "INSERT INTO payments (cust_id,pay_price,pay_date,pay_note,user_id)" +
                    "VALUES((SELECT cust_id from customer where cust_name='" + customer_combo.SelectedItem + "') , '" + price_text.Text + "' , '" + FormatDate(date) + "', '"+textBox1.Text+"' ,'" + form.Id + "' )";
                if (db.insertDB(query))
                {
                    if (ch != null)
                    {
                        if (ch.IMG == null)
                        {
                            string query2 = "INSERT INTO checks VALUES('" + ch.Id + "', (SELECT MAX(pay_id) from payments) ,'" + ch.Bank + "'" +
                                            ",'" + ch.Owner + "' , '" + FormatDate(ch.Delv_Date) + "' ," + ch.Price + " ,'" + ch.Notes + "')";
                            db.insertDB(query2);
                        }
                        else
                        {
                            string query2 = "INSERT INTO checks VALUES('" + ch.Id + "', (SELECT MAX(pay_id) from payments) ,'" + ch.Bank + "'" +
                                            ",'" + ch.Owner + "' , '" + FormatDate(ch.Delv_Date) + "' ," + ch.Price + " ,'" + ch.Notes + "',@picture)";
                            db.insertImg(query2, ch.IMG);
                        }
                    }
                    this.Close();
                    if (form != null)
                        form.RefreshPayment(form.payment_query);
                    if (cust_form != null)
                        cust_form.RefreshData();
                }
            }
             else MessageBox.Show("يحب ان تختار زبون\nويجب ان تضل قيمه رقميه في قيمه الكاش");
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
    }
}
