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

namespace Dental_Lab.Dialogs
{
    public partial class Delivery_Dialog : Form
    {
        private int id;
        private string delv_state;
        private ShowBill form;
        private SqlConnectionDB db;
        public Delivery_Dialog(int id,string delv_state,ShowBill form)
        {
            InitializeComponent();
            this.id = id;
            this.delv_state = delv_state;
            this.form = form;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delivery_Dialog_Load(object sender, EventArgs e)
        {
            delv_state_combo.SelectedItem = delv_state;
            db = new SqlConnectionDB();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string s = "";
            
            MessageBox.Show(delv_state_combo.SelectedItem.ToString());
            if (delv_state_combo.SelectedItem.ToString() == "تم التسليم")
                s = ",bill_delv_date='"+FormatDate(DateTime.Today)+"' ";
            string update_query = "UPDATE bill set bill_delv_state='" + delv_state_combo.SelectedItem + "'" + s + " WHERE id='" + id + "'";
            MessageBox.Show(update_query);
            if (db.updateDB(update_query))
            {
                form.RefreshTheBill();
                this.Close();
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
    }
}
