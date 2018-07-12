using Dental_Lab.Main_Forms;
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
    public partial class AddOutcomeForm : Form
    {
        private SettingsForm form;
        private SqlConnectionDB db;
        public AddOutcomeForm(SettingsForm form)
        {
            InitializeComponent();
            this.form = form;
            db = new SqlConnectionDB();
            this.Text = "تعديل المصروف";
            
        }
        private void AddOutcomeForm_Load(object sender, EventArgs e)
        {
            LinkedList<string> types = db.ListOF("SELECT * FROM outcome_type");
            foreach (string s in types)
                type_combo.Items.Add(s);
        }

        private void add_Click(object sender, EventArgs e)
        {
            try {
                string type = type_combo.SelectedItem.ToString();
                double price = Convert.ToDouble(price_txt.Text);
                if (type != "")
                {
                    string insert_query = "INSERT INTO outcome (out_type,out_price,out_date) VALUES('"+type+"','"+price+"','"+FormatDate(date_pic.Value)+"')";
                    if (db.insertDB(insert_query))
                    {
                        
                        this.Close();
                        MessageBox.Show("تم اضافه المصروف");
                        form.RefreshOut(form.out_query);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("لقد ادخلت سعر غير صحيح");
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

      
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
