using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Dental_Lab.Classes;
using Dental_Lab.PrintForms;

namespace Dental_Lab.Show_Forms
{
    public partial class ShowWarrnity : Form
    {
        private int id;
        
        private SqlConnectionDB db;
        private int period=0;
        private string patient = "";
        private string user_role;
        public ShowWarrnity(int id,string user_role)
        {
            InitializeComponent();
            this.id = id;
            this.user_role = user_role;
            if (user_role != "مسؤول")
                edit.Visible = false;
        }

        private void RefreshWarr()
        {
            try
            {
                DataSet data = new DataSet();
                db.selectDB(ref data, "SELECT * FROM warrnity WHERE bill_id='" + id + "'");
                if (data.Tables[0].Rows.Count > 0)
                {
                    DataSet data2 = new DataSet();
                    db.selectDB(ref data2, "SELECT c.cust_name,c.cust_type from customer c,bill b WHERE b.cust_id=c.cust_id and b.id=" + id);
                    patient = data.Tables[0].Rows[0][0].ToString();
                    patient_label.Text = patient;
                    customer_show_label.Text = "اسم ال" + data2.Tables[0].Rows[0][1];
                    customer_label.Text = data2.Tables[0].Rows[0][0].ToString();
                    bill_label.Text = db.SelectStr("SELECT bill_id FROM bill WHERE id='" + id + "'");
                    delv_label.Text = FormatDate(db.SelectDate("SELECT bill_delv_date from bill WHERE bill_id=" + id));
                    period = Convert.ToInt32(data.Tables[0].Rows[0][1].ToString());
                    if (period == 1)
                    {
                        warr_period_label.Text = " سنه";
                    }
                    else if (period == 2)
                    {
                        warr_period_label.Text = " سنتين";
                    }
                    else
                    {
                        warr_period_label.Text = period + " سنوات";
                    }
                }
                else
                {
                    this.Close();
                    MessageBox.Show("لا توجد كفاله");
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try {
                patient=Interaction.InputBox("ادخل اسم المريض", "تعديل اسم المريض", patient + "", 200, 200);
                period = Convert.ToInt32(Interaction.InputBox("ادخل عدد السنين","تعديل سنوات الكفاله",period+"",200,200));
                string update_query = "UPDATE warrnity SET warr_years='"+period+ "',warr_patient='"+patient+"' WHERE bill_id=" + id ;
                if (db.updateDB(update_query)) MessageBox.Show("تم تعديل الفاتوره");
                RefreshWarr();
            }
            catch (FormatException)
            {
                MessageBox.Show("ادخل رقم صحيح");
            }
        }
        private string FormatDate(DateTime date)
        {
            string datestr = date.Year + "/" + date.Month + "/" + date.Day;
            return datestr;
        }

        private void print_Click(object sender, EventArgs e)
        {
            Warrnity_Class warrnity = new Warrnity_Class(patient_label.Text,customer_label.Text,customer_show_label.Text,bill_label.Text,warr_period_label.Text,delv_label.Text);
            new WarrPrintForm(warrnity).ShowDialog();
        }

        private void ShowWarrnity_Load(object sender, EventArgs e)
        {
            db = new SqlConnectionDB();
            RefreshWarr();
        }
    }
}
