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
    public partial class AddNeedForm : Form
    {
        private SqlConnectionDB db;
        private MainForm form;
        public AddNeedForm(MainForm form)
        {
            InitializeComponent();
            db = new SqlConnectionDB();
            this.form = form;
            foreach (string s in db.ListOF("SELECT * FROM items_type"))
                name_combo.Items.Add(s);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                if (name_combo.SelectedItem.ToString() != "") {
                    int amount = Convert.ToInt32(amount_txt.Text);
                    string insert = "INSERT INTO need (need_name,need_amount,need_date) VALUES('" + name_combo.SelectedItem + "','"+amount+"','"+FormatDate(DateTime.Today)+"')";
                    if (db.insertDB(insert))
                    {
                        this.Close();
                        MessageBox.Show("تم ادخاله الناقص");
                        form.RefreshNeed(form.need_query);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ادخل كميه صحيحه");
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
