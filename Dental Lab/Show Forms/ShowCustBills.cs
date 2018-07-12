using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Dental_Lab.PrintForms;
using Dental_Lab.Dialogs;
using MySql.Data.MySqlClient;
using Dental_Lab.Add_Forms;

namespace Dental_Lab.Show_Forms
{
    public partial class ShowCustBills : Form
    {
        private SqlConnectionDB db;
        private int Id;
        private int User_id;
        private double final_amount;
        public ShowCustBills(int Id,int user_id)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.Id = Id;
            db = new SqlConnectionDB();
            this.User_id = user_id;
            //RefreshData("");

        }
        private void ShowCustBills_Load(object sender, EventArgs e)
        {
            DateTime PreMonth = DateTime.Today.AddMonths(-1);
            datefrom_pic.Value = PreMonth;
            RefreshData();
        }
        public void SetSale(double result,DateTime date,String discount)
        {
            sale_label.Text = result + "";
            double sale = Convert.ToDouble(total.Text) - result;
            string insert_query2 = "INSERT INTO discounts (cust_id,dis_date,dis_total,dis_ratio,dis_price,user_id) " +
                "VALUES ("+Id+" , '"+FormatDate(date)+"' , '"+final_amount+"' , '"+discount+"' , '"+(final_amount-result)+"' , '"+User_id+"')";
            if (db.insertDB(insert_query2))
            {
                RefreshData();
                discount_tab.Select();
            }

        }
        public void RefreshData()
        {
            try
            {
                string teethe_query = "SELECT COALESCE(GROUP_CONCAT(t.number SEPARATOR ','),'مثبت') FROM teeth t WHERE t.bill_id=bill.id";
                String bill_query = "SELECT id as 'الرقم التسلسلي',bill_id as 'رقم الفاتوره' , bill_teethes as 'عدد الاسنان' , ("+teethe_query+") as 'الاسنان' , bill_price as 'السعر' , bill_rec_date as 'تاريخ الاستلام', bill_delv_state as 'حاله التسليم' from bill WHERE cust_id='"+Id+"' AND bill_rec_date BETWEEN '"+FormatDate(datefrom_pic.Value)+"' AND '"+FormatDate(dateto_pic.Value)+ "' ORDER BY id DESC";
                string payment_query = "SELECT pay_id as 'الرقم التسلسلي' , pay_price as 'قيمه الكاش' , (SELECT COALESCE(SUM(ch_price), 0) FROM checks WHERE bill_id=payments.pay_id) as 'قيمه الشكات' , pay_date as 'تاريخ الدفعه' FROM payments WHERE cust_id='" + Id+ "' AND pay_date BETWEEN '" + FormatDate(datefrom_pic.Value) + "' AND '" + FormatDate(dateto_pic.Value) + "' ORDER BY pay_id DESC";
                String debit_query = "SELECT deb_id as 'الرقم التسلسلي' , deb_date as 'تاريخ الدين' , deb_price as 'قيمه الدين' FROM debits WHERE cust_id="+Id+ " AND deb_date BETWEEN '" + FormatDate(datefrom_pic.Value) + "' AND '" + FormatDate(dateto_pic.Value) + "' ORDER BY deb_id DESC";
                String discount_query = "SELECT dis_id as 'الرقم التسلسلي' , dis_total as 'البلغ الكامل', dis_ratio 'نسبه الخصم' , dis_price as 'المبلغ بعد الخصم' , dis_date as 'تاريخ الخصم' FROM discounts WHERE cust_id=" + Id + " AND dis_date BETWEEN '" + FormatDate(datefrom_pic.Value) + "' AND '" + FormatDate(dateto_pic.Value) + "' ORDER BY dis_id DESC";
                //MessageBox.Show(bill_query);
                DataSet bill_data = new DataSet();
                DataSet payment_data = new DataSet();
                DataSet debit_data = new DataSet();
                DataSet discount_data = new DataSet();
                db.selectDB(ref bill_data, bill_query);
                db.selectDB(ref payment_data, payment_query);
                db.selectDB(ref debit_data, debit_query);
                db.selectDB(ref discount_data, discount_query);
                bill_girdview.DataSource = bill_data.Tables[0];
                payment_gridview.DataSource = payment_data.Tables[0];
                debits_gridview.DataSource = debit_data.Tables[0];
                discount_gridview.DataSource = discount_data.Tables[0];

                DateTime today = DateTime.Today;
                
                date_label.Text = FormatDate(today);
                cust_label.Text = db.SelectStr("SELECT cust_name from customer where cust_id=" + Id);
                double bill_sum = 0;
                double payment_sum = 0;
                double debits_sum = 0;
                double discountsum = 0;
                for(int i = 0; i < bill_girdview.RowCount; i++)
                {
                    if(bill_girdview.Rows[i].Cells[6].Value.ToString() == "تم التسليم")
                    {
                        bill_sum += Convert.ToDouble(bill_girdview.Rows[i].Cells[4].Value.ToString());
                    }
                }
                for (int i = 0; i < payment_gridview.RowCount; i++)
                {
                    double price = Convert.ToDouble(payment_gridview.Rows[i].Cells[1].Value.ToString());
                    double check= Convert.ToDouble(payment_gridview.Rows[i].Cells[2].Value.ToString());
                    payment_sum += price+check;
                }
                for (int i = 0; i < debits_gridview.RowCount; i++)
                {
                    debits_sum += Convert.ToDouble(debits_gridview.Rows[i].Cells[2].Value.ToString());
                }
                for (int i = 0; i < discount_gridview.RowCount; i++)
                {
                    discountsum += Convert.ToDouble(discount_gridview.Rows[i].Cells[3].Value.ToString());
                }
                total.Text = bill_sum + "";
                total_paid_label.Text = payment_sum + "";
                debt_label.Text = debits_sum + "";
                sale_label.Text = discountsum + "";
                final_amount = bill_sum+debits_sum-payment_sum-discountsum;
                final_total_label.Text = final_amount + "";
            }
            catch
            {
                this.Close();
            }
        }
        private string concate(LinkedList<string> list)
        {
            string str = "";
            foreach (string s in list)
                str += s + ",";
            return str.Remove(str.Length-1);
        }
        private void print_Click_1(object sender, EventArgs e)
        {
           
            CustBillDataSet data = new CustBillDataSet();
            string teethe_query = "SELECT COALESCE(GROUP_CONCAT(t.number SEPARATOR ','),'مثبت') FROM teeth t WHERE t.bill_id=b.id";
            string query = "SELECT b.id,bill_id,b.bill_teethes,b.bill_price,b.bill_delv_state,DATE_FORMAT(b.bill_delv_date,'%d %m  %Y') as 'bill_delv_date', ("+teethe_query+") as 'teeth'  FROM bill b WHERE b.cust_id=" + Id + " AND b.bill_rec_date BETWEEN '" + FormatDate(datefrom_pic.Value) + "' AND '" + FormatDate(dateto_pic.Value) + "'";
            db.selectDBprint(ref data, query);
            CustPrintForm report = new CustPrintForm(data, total.Text, cust_label.Text, total_paid_label.Text, sale_label.Text, final_total_label.Text, debt_label.Text);
            report.Show();
        }
        private void Finish()
        {
            String insert_payment="INSERT INTO payments (cust_id,pay_price,pay_date,pay_note,user_id) " +
                "VALUES("+Id+" , '"+final_amount+"', '"+FormatDate(datefrom_pic.Value)+"' , 'تصفيه دين شهر', '"+User_id+"')";
            String insert_debit="INSERT INTO debits (cust_id,deb_price,deb_date,user_id)" +
                " VALUES('"+Id+"', '"+final_amount+"', "+FormatDate(dateto_pic.Value.AddMonths(1))+", '"+User_id+"')";
            if (db.insertDB(insert_payment) && db.insertDB(insert_debit))
            {
                this.Close();
            }
        }
        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_Click(object sender, EventArgs e)
        {
            try
            {
                double money = Convert.ToDouble(total.Text);
                new SaleDialog(this, money,datefrom_pic.Value).Show();
            }
            catch (FormatException)
            {

            }
        }
        private string FormatDate(DateTime today)
        {
            return today.Year + "/" + today.Month + "/" + today.Day;
        }

        private void datefrom_pic_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateto_pic_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void change_Click_1(object sender, EventArgs e)
        {
            new SaleDialog(this, final_amount,datefrom_pic.Value).Show();
        }

        private void add_payment_btn_Click(object sender, EventArgs e)
        {
            new AddPaymentForm(this, datefrom_pic.Value);
        }
    }
}
