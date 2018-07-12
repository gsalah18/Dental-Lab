using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dental_Lab.Add_Forms;
using Dental_Lab.Main_Forms;
using Dental_Lab.Show_Forms;
using System.Threading;
using Dental_Lab.Others;

namespace Dental_Lab
{
    public partial class MainForm : Form
    {
        public int Id;
        private SqlConnectionDB db;
        private string cust_name_search;
        private string cust_type_search;
        public string cust_query = "select cust_id as 'رقم الزبون',cust_name as 'اسم الزبون',cust_type as  'نوع الزبون',cust_email as 'البريد الالكتروني'" + ",'اضفظ' as 'هواتف الزبون' from customer";
        public string bill_query = "SELECT id as 'الرقم التسلسلي',bill_id as 'رقم الفاتوره',(select cust_name from customer where customer.cust_id=bill.cust_id) as 'الزبون',bill_teethes as 'عدد الاسنان',bill_price as 'السعر',bill_rec_date as 'تاريخ الاستلام', bill_delv_state as 'حاله التسليم' from bill  ORDER BY id DESC";
        public string sell_query = "SELECT sell_id as 'رقم التاجر' ,sell_name as 'اسم التاجر' ,sell_no as 'رقم هاتف التاجر' ,sell_email 'البريد الالكتروني للتاجر' from seller";
        public string sell_bill_query = "SELECT s.sbill_id as 'رقم المبيعه',(select sell_name from seller where seller.sell_id=s.sell_id) as 'التاجر', s.sbill_price as 'السعرالكلي' from sell_bill s";
        public string need_query = "SELECT need_id as 'رقم الناقص', need_name as 'اسم الناقص', need_amount as 'كميه الناقص', need_date as 'تاريخ اضافه الناقص' from need";
        public string payment_query = "SELECT pay_id as 'الرقم التسلسلي' , (SELECT cust_name FROM customer WHERE customer.cust_id=payments.cust_id) as 'اسم الزبون' , pay_price as 'قيمه الكاش' , (SELECT COALESCE(SUM(ch_price), 0) FROM checks WHERE bill_id=payments.pay_id) as 'قيمه الشكات' , pay_date as 'تاريخ الدفعه' FROM payments ORDER BY pay_id DESC";
        private Thread th;
        private DataSet user_data;
        private string user_role;
        public MainForm(int Id)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.Id = Id;
            db = new SqlConnectionDB();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            new Thread(() => {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {


                        user_data = new DataSet();
                        db.selectDB(ref user_data, "SELECT * FROM users WHERE user_id='" + Id + "'");
                        string title_select = user_data.Tables[0].Rows[0][2].ToString();
                        if (user_data.Tables[0].Rows.Count > 0)
                            title.Text = "مرحبا " + title_select;
                        user_role = user_data.Tables[0].Rows[0][4].ToString();
                        if (user_role != "مسؤول")
                        {
                            settings.Visible = false;
                            del_bill.Visible = false;
                            edit_cust.Visible = false;
                            del_cust.Visible = false;
                            dell_sell_bill.Visible = false;
                            sell_bill_gridview.Visible = false;
                        }

                        cust_type_search = "";
                        cust_name_search = "";
                        date_combo.SelectedIndex = 0;
                        th = new Thread(new ThreadStart(UpdateEach10Mins));
                        th.Start();
                    }
                    ));
                }
            }).Start();
            //RefreshCust(cust_query);
            //RefreshBill(bill_query);

            
        }

        private void settings_Click(object sender, EventArgs e)
        {
            new SettingsForm(Id).Show();
            this.Close();
        }

        private void add_bill_Click(object sender, EventArgs e)
        {
            new PaymentOrBillForm(this).Show();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
        private void add_cust_btn_Click(object sender, EventArgs e)
        {
            new AddCustomerForm(this).Show();
        }
        public void RefreshCust(string statment)
        {
            try
            {
                DataSet data = new DataSet();
                db.selectDB(ref data, statment);
                cust_gridview.DataSource = data.Tables[0];
            }
            catch
            {

            }
        }
        public void RefreshBill(string statment)
        {
            try
            {

                DataSet data = new DataSet();
                db.selectDB(ref data, statment);
                bill_girdview.DataSource = data.Tables[0];
                      
                
            }
            catch
            {

            }
        }
        public void RefreshPayment(string statment)
        {
            try
            {
                DataSet data = new DataSet();
                db.selectDB(ref data, statment);
                payment_gridview.DataSource = data.Tables[0];
            }
            catch
            {

            }
        }
        public void RefreshSell(string statment)
        {
            try
            {
                DataSet data = new DataSet();
                db.selectDB(ref data, statment);
                sell_datagirdview.DataSource = data.Tables[0];
            }
            catch
            {

            }
        }
        public void RefreshSellBill(string statment)
        {
            try
            {
                DataSet data = new DataSet();
                db.selectDB(ref data, statment);
                sell_bill_gridview.DataSource = data.Tables[0];
            }
            catch
            {

            }
        }
        public void RefreshNeed(string statment)
        {
            try
            {
                DataSet data = new DataSet();
                db.selectDB(ref data, statment);
                need_gridview.DataSource = data.Tables[0];
            }
            catch
            {

            }
        }
        private void cust_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(cust_gridview.Rows[e.RowIndex].Cells[0].Value);
                LinkedList<string> phones = db.ListOF("select number from phones where cust_id=" + id);
                string str = "";
                foreach(string s in phones)
                {
                    str += s + "\n";
                }
                MessageBox.Show(str);
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cust_name_search = search_txt.Text;
            string search_query = cust_query+" WHERE cust_name like '%" + cust_name_search + "%' and cust_type like '%" + cust_type_search + "%'";
            RefreshCust(search_query);
        }

        private void search_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(search_combo.SelectedIndex==0)
                cust_type_search = "";
            else
                cust_type_search = search_combo.SelectedItem.ToString();
            string search_query = cust_query + " WHERE cust_name like '%" + cust_name_search + "%' and cust_type like '%" + cust_type_search + "%'";
            RefreshCust(search_query);
        }
        private void BillSearch()
        {
            String order = " ORDER BY id DESC";
            String str = bill_query.Substring(0,bill_query.Length - (order.Length));
            if (date_combo.SelectedIndex == 0)
            {
                string q = str + "WHERE bill_id like '%" + bill_search_txt.Text + "%'"+order;
                RefreshBill(q);
            }
            else if (date_combo.SelectedIndex == 1)
            {
                string search_query = str + "WHERE year(bill_rec_date)='" + search_date.Value.Year + "' and bill_id like '%" + bill_search_txt.Text + "%'" + order;
                RefreshBill(search_query);
            }
            else if (date_combo.SelectedIndex == 2)
            {
                string search_query = str + "WHERE year(bill_rec_date)='" + search_date.Value.Year + "' and EXTRACT(MONTH FROM bill_rec_date)='" + search_date.Value.Month + "' and bill_id like '%" + bill_search_txt.Text + "%'" + order;
                RefreshBill(search_query);
            }
            else
            {
                string search_query = str + "WHERE year(bill_rec_date)='" + search_date.Value.Year + "' and EXTRACT(MONTH FROM bill_rec_date)='" + search_date.Value.Month + "' and EXTRACT(DAY FROM bill_rec_date)='" + search_date.Value.Day + "' and bill_id like '%" + bill_search_txt.Text + "%'" + order;
                RefreshBill(search_query);
            }
        }
        private void search_date_ValueChanged(object sender, EventArgs e)
        {
            BillSearch();
        }

        private void date_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillSearch();
        }

        
        
        

        private void cust_gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&& user_role== "مسؤول")
            {
                try
                {
                    int id = Convert.ToInt32(cust_gridview.Rows[e.RowIndex].Cells[0].Value);
                    new ShowCustBills(id,Id).Show();
                }
                catch
                {

                }
            }
        }

        private void bill_girdview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(bill_girdview.Rows[e.RowIndex].Cells[0].Value);
                new ShowBill(id,Id).Show();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int index = cust_gridview.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(cust_gridview.Rows[index].Cells[0].Value);
            new AddCustomerForm(this, id).Show();
        }
        private void UpdateEach10Mins()
        {
            while (true)
            {
                Thread.Sleep(300000);
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        RefreshBill(bill_query);
                        RefreshPayment(payment_query);
                        RefreshCust(cust_query);
                    }
                    ));

                }
            }
        }

        
        

        private void del_bill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الفاتوره","حذف فاتوره",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = bill_girdview.SelectedCells[0].RowIndex;
                if (index >= 0)
                {
                    int id = Convert.ToInt32(bill_girdview.Rows[index].Cells[0].Value);
                    

                    if (db.deleteDB("DELETE from bill WHERE id=" + id))
                    {
                        string lastIndex = db.ListOF("select id from bill ORDER BY id").Last();
                        int i = Convert.ToInt32(lastIndex) + 1;
                       
                        db.ExeQuery("ALTER TABLE bill AUTO_INCREMENT = "+i);
                        RefreshBill(bill_query);
                        MessageBox.Show("تم حذف الفاتوره");
                    }
                }
            }
        }

        private void del_cust_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الزبون", "حذف زبون", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = cust_gridview.SelectedCells[0].RowIndex;
                if (index >= 0)
                {
                    if (db.deleteDB("DELETE from customer WHERE cust_id=" + cust_gridview.Rows[index].Cells[0].Value))
                    {
                        string lastIndex = db.ListOF("select cust_id from customer ORDER BY cust_id").Last();
                        int i = Convert.ToInt32(lastIndex) + 1;
                        MessageBox.Show(lastIndex);
                        db.ExeQuery("ALTER TABLE customer AUTO_INCREMENT = " + i);
                        RefreshCust(cust_query);
                        MessageBox.Show("تم حذف الزبون");
                    }
                }
            }
        }

        private void ref_cust_Click(object sender, EventArgs e)
        {
            RefreshCust(cust_query);
        }

        

        

        private void ref_bill_Click(object sender, EventArgs e)
        {
            RefreshBill(bill_query);
        }

        private void bill_search_txt_TextChanged(object sender, EventArgs e)
        {
            BillSearch();
        }
        

        private void type_search_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillSearch();
        }

        private void ref_sell_Click(object sender, EventArgs e)
        {
            RefreshSell(sell_query);
        }

        private void add_seller_Click(object sender, EventArgs e)
        {
            new AddSellerForm(this).Show();
        }
        

        private void txt_seller_search_TextChanged(object sender, EventArgs e)
        {
            string search_query = sell_query + " WHERE sell_name like '%" + txt_seller_search.Text + "%'";
            RefreshSell(search_query);
        }

        private void edit_seller_Click(object sender, EventArgs e)
        {
            int index = sell_datagirdview.SelectedCells[0].RowIndex;
            if (index >= 0)
            {
                int id = Convert.ToInt32(sell_datagirdview.Rows[index].Cells[0].Value);
                new AddSellerForm(this, id).Show();
            }
        }

        private void ref_sell_bill_Click(object sender, EventArgs e)
        {
            RefreshSellBill(sell_bill_query);
        }

        private void add_sell_bill_Click(object sender, EventArgs e)
        {
            new AddSellBillForm(this).Show();
        }

        private void del_seller_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف التاجر", "حذف التاجر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = sell_datagirdview.SelectedCells[0].RowIndex;
                if (index >= 0)
                {
                    int id = Convert.ToInt32(sell_datagirdview.Rows[index].Cells[0].Value);


                    if (db.deleteDB("DELETE from seller WHERE sell_id=" + id))
                    {
                        string lastIndex = db.ListOF("select sell_id from seller ORDER BY sell_id").Last();
                        int i = Convert.ToInt32(lastIndex) + 1;

                        db.ExeQuery("ALTER TABLE seller AUTO_INCREMENT = " + i);
                        RefreshBill(bill_query);
                        MessageBox.Show("تم حذف التاجر");
                    }
                }
            }
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == billtab&&billselected)
            {
                RefreshBill(bill_query);
                billselected = false;
            }
            else if (tabControl1.SelectedTab == paymenttab && payselected)
            {
                RefreshPayment(payment_query);
                payselected = false;
            }
            else if (tabControl1.SelectedTab == customertab&&custselected)
            {
                RefreshCust(cust_query);
                custselected = false;
            }else if (tabControl1.SelectedTab == sellerstab&& sellselected)
            {
                RefreshSell(sell_query);
                sellselected = false;
            }else if (tabControl1.SelectedTab == sellbiltab && sellbillselected)
            {
                RefreshSellBill(sell_bill_query);
            }else if (tabControl1.SelectedTab == needstab && needselected)
            {
                RefreshNeed(need_query);
            }
        }
        bool billselected = true,payselected=true, custselected = true, sellselected = true, sellbillselected = true,needselected=true;

        private void need_add_Click(object sender, EventArgs e)
        {
            new AddNeedForm(this).Show();
        }

        private void need_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الناقص", "حذف الناقص", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = need_gridview.SelectedCells[0].RowIndex;
                if (index >= 0)
                {
                    int id = Convert.ToInt32(need_gridview.Rows[index].Cells[0].Value);


                    if (db.deleteDB("DELETE from need WHERE need_id=" + id))
                    {
                        string lastIndex = db.ListOF("select need_id from need ORDER BY need_id").Last();
                        int i = Convert.ToInt32(lastIndex) + 1;

                        db.ExeQuery("ALTER TABLE need AUTO_INCREMENT = " + i);
                        RefreshBill(bill_query);
                        MessageBox.Show("تم حذف الناقص");
                    }
                }
            }
        }

      
        private void bill_girdview_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && user_role == "مسؤول")
            {
                try
                {
                    int id = Convert.ToInt32(bill_girdview.Rows[e.RowIndex].Cells[0].Value);
                    new ShowBill(id, Id).Show();
                }
                catch
                {

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AddPaymentForm(this).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshPayment(payment_query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (payment_gridview.SelectedCells.Count > 0)
            {
                if (payment_gridview.SelectedCells.Count == 1)
                {
                    if (MessageBox.Show("هل تريد حذف الدفعه", "حذف فاتوره", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(payment_gridview.Rows[payment_gridview.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                        string query = "DELETE FROM payments WHERE pay_id='"+id+"'";
                        if (db.deleteDB(query))
                        {
                            RefreshPayment(payment_query);
                        }
                    }
                    
                }
                else MessageBox.Show("يجب ان تختار دفعه واحد لتعديله");
            }
        }

        private void payment_gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && user_role == "مسؤول")
            {
                try
                {
                    int id = Convert.ToInt32(payment_gridview.Rows[e.RowIndex].Cells[0].Value);
                    new ShowPaymentForm(id).Show();
                }
                catch
                {

                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string s = need_query + " WHERE need_name='"+textBox1.Text+"'";
            RefreshNeed(need_query);
        }

        private void need_ref_Click(object sender, EventArgs e)
        {
            RefreshNeed(need_query);
        }

        private void dell_sell_bill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف  الفاتوره", "حذف الفاتوره", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = sell_bill_gridview.SelectedCells[0].RowIndex;
                if (index >= 0)
                {
                    int id = Convert.ToInt32(sell_bill_gridview.Rows[index].Cells[0].Value);


                    if (db.deleteDB("DELETE from sell_bill WHERE sbill_id=" + id))
                    {
                        string lastIndex = db.ListOF("select sbill_id from sell_bill ORDER BY sell_bill_id").Last();
                        int i = Convert.ToInt32(lastIndex) + 1;

                        db.ExeQuery("ALTER TABLE sell_bill AUTO_INCREMENT = " + i);
                        RefreshSellBill(sell_bill_query);
                        MessageBox.Show("تم حذف الفاتوره");
                    }
                }
            }
        }

        private void sell_bill_gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32(sell_bill_gridview.Rows[e.RowIndex].Cells[0].Value.ToString());
            new ShowSellBillItemsForm(id).Show();
        }
    }
}
