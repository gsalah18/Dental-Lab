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

namespace Dental_Lab.Add_Forms
{
    public partial class AddCustomerForm : Form
    {
        private MainForm form;
        private int id;
        SqlConnectionDB db;
        int cases;
        public AddCustomerForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
            db = new SqlConnectionDB();
            cases = 1;
        }
        public AddCustomerForm(MainForm form,int id)
        {
            InitializeComponent();
            this.id = id;
            this.form = form;
            db = new SqlConnectionDB();
            save.Text = "تعديل";
            this.Text = "تعديل الزبون";
            cases = 2;
            name_txt.Text = db.ListOF("SELECT cust_name from customer where cust_id="+id).ElementAt(0);
            string type = db.ListOF("SELECT cust_type from customer where cust_id=" + id).ElementAt(0);
            if (type == "دكتور")
                type_combo.SelectedIndex = 0;
            else if (type == "مختبر")
                type_combo.SelectedIndex = 1;
            else type_combo.SelectedIndex = 2;
            email_txt.Text= db.ListOF("SELECT cust_email from customer where cust_id=" + id).ElementAt(0);
            phone_list.Clear();
            foreach (string s in db.ListOF("Select number from phones where cust_id=" + id))
                phone_list.Items.Add(s);

        }
        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            if (cases == 2)
            {
                DataSet data = new DataSet();
                db.selectDB(ref data,"SELECT * FROM customer WHERE cust_id=" + id);
                LinkedList<string> phones = db.ListOF("Select number from phones where cust_id=" + id);
                name_txt.Text = data.Tables[0].Rows[0][1].ToString();
                string type = data.Tables[0].Rows[0][2].ToString();
                if (type == "دكتور")
                    type_combo.SelectedIndex = 0;
                else if (type == "مختبر")
                    type_combo.SelectedIndex = 1;
                else type_combo.SelectedIndex = 2;
                email_txt.Text = data.Tables[0].Rows[0][3].ToString();
                phone_list.Clear();
                foreach (string s in phones)
                    phone_list.Items.Add(s);

            }
        }



        private void add_phone_Click(object sender, EventArgs e)
        {
            string phone = Interaction.InputBox("ادخل رقم الهاتف", "رقم هاتف","", 200, 200);
            if (CheckPhone(phone))
            {
                phone_list.Items.Add(phone);
            }
            else MessageBox.Show("ادخل رقم هاتف صحيح");
        }
        private bool CheckPhone(string phone)
        {
            bool test = true;
            for(int i = 0; i < phone.Length; i++)
            {
                if (!(phone.ElementAt(i) >= '0' && phone.ElementAt(i) <= '9'))
                {
                    test = false;
                    break;
                }
            }
            return test;
        }

        private void del_phone_Click(object sender, EventArgs e)
        {
            if (phone_list.SelectedIndices.Count > 0)
            {
                phone_list.Items.RemoveAt(phone_list.SelectedIndices[0]);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            string type = type_combo.SelectedItem.ToString();
            string email = email_txt.Text;
            
            if (name != "" && type != "")
            {
                if (cases == 1)
                {
                    string insert_query = "INSERT INTO customer (cust_name,cust_type,cust_email) VALUES('" + name + "','" + type + "','" + email + "')";
                    if (db.insertDB(insert_query))
                    {
                        int id = db.SelectID("SELECT cust_id FROM customer WHERE cust_name='" + name + "'");
                        for (int i = 0; i < phone_list.Items.Count; i++)
                        {
                            string p = phone_list.Items[i].Text;
                            string query = "INSERT INTO phones VALUES('" + p + "'," + id + ")";
                            if (db.insertDB(query))
                            {
                                
                            }
                        }
                        MessageBox.Show("تم اضافه الزبون");
                        this.Close();
                        form.RefreshCust(form.cust_query);
                    }
                }else if (cases == 2)
                {
                    string update_query = "UPDATE customer SET cust_name='" + name + "',cust_type='" + type + "',cust_email='" + email + "' WHERE cust_id="+id;
                    if (db.updateDB(update_query))
                    {
                        db.deleteDB("DELETE FROM phones WHERE cust_id=" + id);
                        for (int i = 0; i < phone_list.Items.Count; i++)
                        {
                            string p = phone_list.Items[i].Text;
                            string query = "INSERT INTO phones VALUES('" + p + "'," + id + ")";
                            if (db.insertDB(query))
                            {
                                
                            }
                        }
                        MessageBox.Show("تم تعديل معلومات الزبون الزبون");
                        this.Close();
                        form.RefreshCust(form.cust_query);
                    }
                }
            }
            else MessageBox.Show("ادخل معلومات صحيحه");
        }

    }
}
