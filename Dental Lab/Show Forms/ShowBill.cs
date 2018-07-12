using Dental_Lab.Classes;
using Dental_Lab.Dialogs;
using Dental_Lab.PrintForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Show_Forms
{
    public partial class ShowBill : Form
    {
        private int Id,user_id;
     
        private SqlConnectionDB db;
        private DataSet data;
        private string user_role;
        private DateTime rec;
        public ShowBill(int Id,int user_id)
        {
            InitializeComponent();
            this.Id = Id;
            this.user_id = user_id;
        }
        private void ShowBill_Load(object sender, EventArgs e)
        {
                db = new SqlConnectionDB();
                RefreshTheBill();
        }
        public void RefreshTheBill()
        {
            try
            {
                data = new DataSet();
                
                DataSet data2 = new DataSet();
                new Thread(() =>
                {
                    if (InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            db.selectDB(ref data, "SELECT * FROM bill where id='" + Id + "'");
                            db.selectDB(ref data2, "SELECT cust_name,cust_type from customer  where cust_id='" + data.Tables[0].Rows[0][2] + "'");

                            DataSet dataUser = new DataSet();
                            db.selectDB(ref dataUser, "SELECT user_fullname from users WHERE user_id='" + data.Tables[0].Rows[0][11] + "'");
                            name_label.Text = "اسم ال" + data2.Tables[0].Rows[0][1];
                            pk_label.Text = Id + "";
                            id_label.Text = data.Tables[0].Rows[0][1].ToString();
                            cust_label.Text = data2.Tables[0].Rows[0][0].ToString();
                            rec_label.Text = FormatDate(Convert.ToDateTime(data.Tables[0].Rows[0][7]));
                            teeth_label.Text = concate(db.ListOF("SELECT number from teeth where bill_id=" + Id));
                            type_label.Text = data.Tables[0].Rows[0][5].ToString();
                            string delv_state = data.Tables[0].Rows[0][6].ToString();
                            delv_state_label.Text = delv_state;
                            if (delv_state != "لم يسلم")
                            {
                                delv_label.Text = FormatDate(Convert.ToDateTime(data.Tables[0].Rows[0][8].ToString()));
                                delv_show_label.Visible = true;
                                delv_label.Visible = true;
                            }
                            else
                            {
                                delv_show_label.Visible = false;
                                delv_label.Visible = false;
                            }
                            color_label.Text = data.Tables[0].Rows[0][4].ToString();
                            price_label.Text = data.Tables[0].Rows[0][9].ToString();
                            notes_label.Text = data.Tables[0].Rows[0][10].ToString();
                            user_label.Text = dataUser.Tables[0].Rows[0][0].ToString();
                            user_role = db.SelectStr("SELECT user_role from users WHERE user_id=" + user_id);

                            DateTime rec = Convert.ToDateTime(data.Tables[0].Rows[0][7]);
                            this.rec = rec;

                            today_label.Text = FormatDate(DateTime.Today);
                            
                        }));
                    }
                }).Start();
            }
            catch
            {
                this.Close();
            }
        }
        
        private string FormatDate(DateTime date)
        {
            string datestr = date.Year+"/"+date.Month+"/"+date.Day;
            return datestr;
        }
        private string concate(LinkedList<string> list)
        {
            string str = "";
            foreach (string s in list)
                str += s + ",";
            if(str.Length>0)
                str=str.Remove(str.Length - 1);
            return str;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void print_Click(object sender, EventArgs e)
        {
            
            string delv_date = delv_label.Text;
            if (delv_label.Visible == false)
                delv_date = "-";
            Bill_Class bill=new Bill_Class(id_label.Text,cust_label.Text,rec_label.Text,delv_date,teeth_label.Text,type_label.Text,delv_state_label.Text,
                color_label.Text,price_label.Text,notes_label.Text,today_label.Text);
            new BillPrintForm(bill).ShowDialog();
        }

   
        private void edit_Click(object sender, EventArgs e)
        {
            if (user_role != "مسؤول" && !rec.Equals(DateTime.Today))
            {
                new Delivery_Dialog(Id,delv_state_label.Text,this).Show();
            }
            else
            {
                new AddBillForm(this, Id).Show();
            }
        }

        private void show_warr_Click(object sender, EventArgs e)
        {
            new ShowWarrnity(Id,user_role).Show();
        }

        private void show_checks_Click(object sender, EventArgs e)
        {
            new ShowCheck(Id,user_role).Show();
        }

       
    }
}
