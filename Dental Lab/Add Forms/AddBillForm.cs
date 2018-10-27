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
using Dental_Lab.Add_Forms;
using Dental_Lab.Show_Forms;
using System.Threading;

namespace Dental_Lab
{
    public partial class AddBillForm : Form
    {
        private MainForm form;
        private ShowBill form2;
        private double price = 0;
        //private double checkP = 0;
        private int warr_years=0;
        private string patient="";
        private bool[] teethes_list=null;
        private int bill_id;
        SqlConnectionDB db;
        int cases;
        public AddBillForm(MainForm form)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            db = new SqlConnectionDB();
            this.form = form;
            cases = 1;
        }
        public AddBillForm(ShowBill form2,int bill_id)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.form2 = form2;
            this.bill_id = bill_id;
            db = new SqlConnectionDB();
            cases = 2;
            this.Text = "تعديل الفاتوره";
            save.Text = "تعديل";
        }
        private void AddBillForm_Load(object sender, EventArgs e)
        {
            foreach (string s in db.ListOF("select * from teeth_type"))
                type_combo.Items.Add(s);
            foreach (string s in db.ListOF("select * from color_type"))
                color_combo.Items.Add(s);
            if (cases == 2)
            {
                DataSet data1 = new DataSet();
                db.selectDB(ref data1, "SELECT * FROM bill WHERE id='" + bill_id + "'");
                DataSet data2 = new DataSet();
                db.selectDB(ref data2, "SELECT cust_name,cust_type from customer WHERE cust_id='" + data1.Tables[0].Rows[0][2] + "'");
                LinkedList<string> teethes_data = db.ListOF("SELECT number from teeth where bill_id='" + bill_id + "'");
                teethes.Text = "تعديل الاسنان";
                save.Text = "تعديل";
                id_txt.Text = data1.Tables[0].Rows[0][1].ToString();
                cust_type_combo.SelectedItem = data2.Tables[0].Rows[0][1].ToString();
                customer_combo.SelectedItem = data2.Tables[0].Rows[0][0].ToString();
                teethes_list = new bool[49];
                for (int i = 0; i < teethes_list.Length; i++)
                    teethes_list[i] = false;
                foreach (string s in teethes_data)
                {
                    int index = Convert.ToInt32(s);
                    teethes_list[index] = true;
                }
                teethes_txt.Text = data1.Tables[0].Rows[0][3].ToString();
                color_combo.SelectedItem = data1.Tables[0].Rows[0][4].ToString();
                type_combo.SelectedItem = data1.Tables[0].Rows[0][5].ToString();
                price_txt.Text = data1.Tables[0].Rows[0][9].ToString();
                delv_state_combo.SelectedItem = data1.Tables[0].Rows[0][6].ToString();
                price = Convert.ToDouble(price_txt.Text);
                notes_txt.Text = data1.Tables[0].Rows[0][10].ToString();
                warrnity.Visible = false;
                warr_txt.Visible = false;  
            }
        }

        public void SetTeethes(bool[] result) {
            this.teethes_list = result;
            teethes.Text = "تعديل ارقام الاسنان";
            int count = 0;
            foreach (bool b in result)
                if (b)
                    count++;
            teethes_txt.Text = count + "";
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

    


     

        private void warrnity_Click(object sender, EventArgs e)
        {
            try
            {
                patient = Interaction.InputBox("ادخل اسم المريض", "المريض", "ادخل اسم المريض", 200, 200);
                warr_years = Convert.ToInt32(Interaction.InputBox("ادخل سنين الكفاله", "الكفاله", "ادخل الكفاله", 200, 200));
            }
            catch (FormatException)
            {
                MessageBox.Show("لقدت ادخلت سنين غير صحيحه");
            }
            warr_txt.Text = warr_years + "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (cases == 1)
            {
                try
                {
                    int id = Convert.ToInt32(id_txt.Text);
                    string cust_type = cust_type_combo.SelectedItem.ToString();
                    string cust_name = customer_combo.SelectedItem.ToString();
                    int teethes_count = Convert.ToInt32(teethes_txt.Text);
                    string color = color_combo.SelectedItem.ToString(); ;
                    string type = type_combo.SelectedItem.ToString();
                    string delv_state = delv_state_combo.SelectedItem.ToString();
                    price = Convert.ToDouble(price_txt.Text);


                    DateTime rec_date = DateTime.Today;
                    DateTime delv_date = DateTime.Today;
                    if (delv_state == "لم يسلم")
                        delv_date = new DateTime();
                    string notes = notes_txt.Text;
                    if (cust_type != "" && cust_name != "" && teethes_count > 0 && color != "" && type != "" && notes != "")
                    {
                        string id_select = "SELECT cust_id from customer where cust_name='" + cust_name + "'";


                        string insert_query2 = "INSERT INTO bill (bill_id,cust_id,bill_teethes,bill_color,bill_type,bill_delv_state,bill_rec_date,bill_delv_date,bill_price,bill_notes,user_id) VALUES('" + id + "' ,'" + db.SelectID(id_select) + "' ,'" + teethes_count +
                            "','" + color + "','" + type + "','" + delv_state + "','" + FormatDate(rec_date) + "' ,'" + FormatDate(delv_date) + "' ,'" + price + "' , '" + notes + "','" + form.Id + "')";

                        string select_id = "SELECT * from bill WHERE bill_id='"+id+"' AND year(bill_rec_date)='"+rec_date.Year+"'";
                        if (!db.DoseExists(select_id))
                        {
                            if (db.insertDB(insert_query2))
                            {
                                int TheId =Convert.ToInt32(db.ListOF("SELECT MAX(id) from bill").Last());
                                if (type != "مثبت"&&type!="حارس ليلي")
                                {
                                    for (int x = 0; x < teethes_list.Length; x++)
                                    {
                                        if (teethes_list[x])
                                        {
                                            string query = "INSERT INTO teeth VALUES('" + x + "','" + TheId + "')";
                                            db.insertDB(query);
                                        }
                                    }
                                }
                                if (warr_years > 0)
                                {
                                    string query = "INSERT INTO warrnity (warr_patient,bill_id,warr_years) VALUES('" + patient + "','" + TheId + "','" + warr_years + "')";
                                    db.insertDB(query);
                                }
                                MessageBox.Show("تم اضافه الفاتوره");
                                this.Close();
                                form.RefreshBill(form.bill_query);
                                if (MessageBox.Show("هل تريد عرض الفاتوره", "تفاصيل الفاتوره", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    new ShowBill(TheId,form.Id).Show();
                                }
                            }

                        }
                        else MessageBox.Show("هذه الفاتوره موجوده");
                    }
                    else MessageBox.Show("تاكد من ادخال جميع القيم بشكل صحيح");
                }
                catch (FormatException)
                {
                    MessageBox.Show("لقد ادخلت ارقام خاطئه");
                }
            }
            else if (cases == 2)
            {
                try
                {
                    int id = Convert.ToInt32(id_txt.Text);
                    string cust_type = cust_type_combo.SelectedItem.ToString();
                    string cust_name = customer_combo.SelectedItem.ToString();
                    int teethes_count = Convert.ToInt32(teethes_txt.Text);
                    string color = color_combo.SelectedItem.ToString();
                    string type = type_combo.SelectedItem.ToString();
                    string delv_state = delv_state_combo.SelectedItem.ToString();
                    double price = Convert.ToDouble(price_txt.Text);
                    DateTime delv_date = DateTime.Today;
                    if (delv_state == "لم يسلم")
                        delv_date = new DateTime();
                    string notes = notes_txt.Text;
                    if (cust_type != "" && cust_name != "" && teethes_count > 0 && color != "" && type != "" && notes != "")
                    {
                        string update_query = "UPDATE bill set bill_id='"+id+ "',cust_id=(SELECT cust_id from customer where cust_name='" + cust_name + "'),bill_teethes='" + teethes_count + "',bill_color='" + color + "',bill_type='" + type + "',bill_delv_state='" + delv_state + "',bill_delv_date='" + FormatDate(delv_date) + "',bill_price='" + price + "',bill_notes='" + notes + "' WHERE id='" + bill_id + "'";
                        if (db.updateDB(update_query))
                        {
                            db.deleteDB("delete from teeth where bill_id='" + bill_id + "'");
                            if (type != "مثبت"&&type!="حارس ليلي")
                            {
                                for (int x = 0; x < teethes_list.Length; x++)
                                {
                                    if (teethes_list[x])
                                    {
                                        string query = "INSERT INTO teeth VALUES('" + x + "','" + bill_id + "')";
                                        db.insertDB(query);
                                    }
                                }
                            }
                            MessageBox.Show("تم تعديل الفاتوره");
                            form2.RefreshTheBill();
                            this.Close();
                        }

                    }
                    else MessageBox.Show("تاكد من ادخال جميع القيم بشكل صحيح");
                }
                catch (FormatException)
                {
                    MessageBox.Show("لقد ادخلت ارقام خاطئه");
                }
            }
            
        }

        private void teethes_Click(object sender, EventArgs e)
        {
            new AddteethesForm(this,teethes_list).Show();
        }
        private string FormatDate(DateTime date)
        {
            string year = date.Year+"";
            string month = "";
            if (date.Month >= 10)
                month = date.Month + "";
            else month = "0" + date.Month;
            string day = date.Day+"";
            return year+"-"+month+"-"+day;
        }

        private void type_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                price_txt.Text = Convert.ToDouble(db.ListOF("SELECT price from teeth_type WHERE type='" + type_combo.SelectedItem + "'").ElementAt(0)) * Convert.ToInt32(teethes_txt.Text) + "";
            }
            catch
            {
            }
        }

        private void teethes_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                price_txt.Text = Convert.ToDouble(db.ListOF("SELECT price from teeth_type WHERE type='" + type_combo.SelectedItem + "'").ElementAt(0)) * Convert.ToInt32(teethes_txt.Text) + "";
            }
            catch (Exception)
            {
            }
            
        }
    }
}
