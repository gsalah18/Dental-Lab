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
    public partial class AddSellerForm : Form
    {
        private SqlConnectionDB db;
        private MainForm form;
        private int id;
        private int casses;
        public AddSellerForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
            db = new SqlConnectionDB();
            casses = 1;
        }
        public AddSellerForm(MainForm form,int id)
        {
            InitializeComponent();
            this.form = form;
            db = new SqlConnectionDB();
            this.id = id;
            casses = 2;
            this.Text = "تعديل التاجر";
            button1.Text = "تعديل";
            DataSet data = new DataSet();
            db.selectDB(ref data, "SELECT * FROM seller WHERE sell_id=" + id);
            name_txt.Text = data.Tables[0].Rows[0][1].ToString();
            phone_txt.Text = data.Tables[0].Rows[0][2].ToString();
            email_txt.Text = data.Tables[0].Rows[0][3].ToString();

        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (name_txt.Text != "" && phone_txt.Text != "")
                {
                    if (casses==1)
                    {
                        string insert_query = "INSERT INTO seller (sell_name,sell_no,sell_email) VALUES('" + name_txt.Text + "','" + phone_txt.Text + "','" + email_txt.Text + "')";
                        if (db.insertDB(insert_query))
                        {
                            MessageBox.Show("تم ادخال التاجر");
                            this.Close();
                            form.RefreshSell(form.sell_query);
                        }
                    }else if (casses == 2)
                    {
                        string update_query = "UDPATE seller SET sell_name='"+name_txt.Text+"',sell_no='"+phone_txt.Text+"',sell_email='"+email_txt.Text+"' WHERE sell_id=" + this.id;
                        if (db.updateDB(update_query))
                        {
                            MessageBox.Show("تم تعديل التاجر");
                            this.Close();
                            form.RefreshSell(form.sell_query);
                        }
                    }
                }
                else MessageBox.Show("يجب ملئ خانتي الاسم والرقم");
            }
            catch (FormatException)
            {
                MessageBox.Show("ادخل رقم هاتف صحيح");
            }
        }
        private bool isANumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!char.IsDigit(s[i]))
                    return false;
            return true;
        }
    }
}
