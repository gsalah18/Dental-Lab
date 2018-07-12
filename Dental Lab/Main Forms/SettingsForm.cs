using Dental_Lab.Add_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Main_Forms
{
    public partial class SettingsForm : Form
    {
        private SqlConnectionDB db;
        private int cust_id;
        public string out_query = "SELECT out_id as 'رقم المصروف',out_type as 'نوع المصروف',out_price as 'سعر المصروف',out_date as 'تاريخ المصروف' from outcome";
        public SettingsForm(int cust_id)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.cust_id = cust_id;
            
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            db = new SqlConnectionDB();
            
            date_combo2.SelectedIndex = 0;
           
            
            
            
            
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == types)
            {
                RefreshTeeth();
            }else if (tabControl1.SelectedTab == accounts)
            {
                RefreshAccount();
            }else if (tabControl1.SelectedTab == outcomes_type)
            {
                RefreshOutType();
            }else if (tabControl1.SelectedTab == outcome)
            {
                foreach (string s in db.ListOF("SELECT * FROM outcome_type"))
                    outcome_type_combo.Items.Add(s);
                outcome_type_combo.SelectedIndex = 0;
                RefreshOut(out_query);
            }else if (tabControl1.SelectedTab == colortab)
            {
                RefreshColorType();
            }else if (tabControl1.SelectedTab == needitemstab)
            {
                RefreshNeedItems();
            }
        }
        private void OutSearch()
        {
            string type = "";
            if (outcome_type_combo.SelectedIndex > 0)
                type = outcome_type_combo.SelectedItem.ToString();

            if (date_combo2.SelectedIndex == 0)
            {
                RefreshOut(out_query + " WHERE out_type like '%" + type + "%'");
            }
            else if (date_combo2.SelectedIndex == 1)
            {
                string search_query = out_query + " WHERE out_type like '%" + type + "%' and year(out_date)='" + outcome_date_pic.Value.Year + "'";
                RefreshOut(search_query);
            }
            else if (date_combo2.SelectedIndex == 2)
            {
                string search_query = out_query + " WHERE out_type like '%" + type + "%' year(out_date)='" + outcome_date_pic.Value.Year + "' and EXTRACT(MONTH FROM out_date)='" + outcome_date_pic.Value.Month + "'";
                RefreshOut(search_query);
            }
            else
            {
                string search_query = out_query + " WHERE out_type like '%" + type + "%' year(out_date)='" + outcome_date_pic.Value.Year + "' and EXTRACT(MONTH FROM out_date)='" + outcome_date_pic.Value.Month + "' and EXTRACT(DAY FROM out_date)='" + outcome_date_pic.Value.Day + "'";
                RefreshOut(search_query);
            }
        }
        public void RefreshOut(string statment)
        {
            DataSet data = new DataSet();
            db.selectDB(ref data, statment);
            outcome_gridview.DataSource = data.Tables[0];
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm(cust_id).Show();
        }


        private void add_teeth_Click(object sender, EventArgs e)
        {
            if (teeth_txt.Text != ""&&price_txt.Text!="")
            {
                try
                {
                    double price = Convert.ToDouble(price_txt.Text);
                    if (db.insertDB("INSERT INTO teeth_type VALUES('" + teeth_txt.Text + "','" + price + "')"))
                    {
                        RefreshTeeth();
                        teeth_txt.Clear();
                        price_txt.Clear();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("ادخل سعر حقيقي");
                }
            }
            else MessageBox.Show("يجب ملئ الخانه لاضافه نوع");
        }

        private void del_teeth_Click(object sender, EventArgs e)
        {
            if (teeth_gridview.SelectedCells.Count > 0)
            {
                string type = teeth_gridview.Rows[teeth_gridview.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                if(db.deleteDB("DELETE from teeth_type WHERE type='" + type + "'"))
                {
                    RefreshTeeth();
                }
            }
        }
        private void RefreshTeeth()
        {
            string teeth_query = "SELECT type as 'نوع السن',price as 'سعر السن' from teeth_type";
            DataSet data = new DataSet();
            db.selectDB(ref data, teeth_query);
            teeth_gridview.DataSource = data.Tables[0];
        }
        private void RefreshAccount()
        {
            string acc_select = "SELECT user_id as 'رقم المستخدم',user_name as 'اسم المستخدم',user_fullname as 'الاسم الكامل',user_password as 'الرقم السري',user_role as 'دور الحساب' from users";
            DataSet data = new DataSet();
            db.selectDB(ref data, acc_select);
            account_gridview.DataSource = data.Tables[0];
        }

   
     

        private void clear_Click(object sender, EventArgs e)
        {
            id_txt.Clear();
            username_txt.Clear();
            name_txt.Clear();
            password_txt.Clear();
            role_combo.SelectedIndex = 0;
        }

      
        private void account_gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txt.Text = account_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            username_txt.Text = account_gridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            name_txt.Text = account_gridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            password_txt.Text = account_gridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            string role = account_gridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (role == "مسؤول")
                role_combo.SelectedIndex = 0;
            else role_combo.SelectedIndex = 1;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (username_txt.Text != "" && name_txt.Text != "" && password_txt.Text != "" && role_combo.SelectedIndex >= 0)
            {
                string insert_query = "INSERT INTO users (user_name,user_fullname,user_password,user_role)"
                    + " VALUES('" + username_txt.Text + "','" + name_txt.Text + "','" + password_txt.Text + "','" + role_combo.SelectedItem.ToString() + "')";
                if (db.insertDB(insert_query))
                {
                    RefreshAccount();
                }
                else MessageBox.Show("هاذا الحساب موجود مسبقا");
            }
            else MessageBox.Show("يجب تعبئه جميع الخانات للاضافه");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id_txt.Text != ""&& username_txt.Text != "" && name_txt.Text != "" && password_txt.Text != "" && role_combo.SelectedIndex >= 0)
            {
                if (MessageBox.Show("هل تريد حذف الحساب", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (db.deleteDB("DELETE FROM users WHERE user_id='" + id_txt.Text + "'"))
                    {
                        RefreshAccount();
                    }
                }
            }
            else MessageBox.Show("يجب اختيار حساب لحذفه");
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id_txt.Text != "")
            {
                if (MessageBox.Show("هل تريد تعديل الحساب", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string update_query = "update users set user_name='" + username_txt.Text + "',user_fullname='" + name_txt.Text + "',user_password='" + password_txt.Text + "',user_role='" + role_combo.SelectedItem.ToString() + "' WHERE user_id='" + id_txt.Text + "'";
                    if (db.updateDB(update_query))
                    {
                        RefreshAccount();
                    }
                }
            }
            else MessageBox.Show("يجب اختيار حساب لتعديله");
        }
        private void RefreshOutType()
        {
            out_list.Clear();
            foreach (string s in db.ListOF("SELECT * FROM outcome_type"))
            {
                out_list.Items.Add(s);
            }
            out_count.Text = "عدد الانواع " + out_list.Items.Count;
        }
        private void out_add_Click(object sender, EventArgs e)
        {
            if (out_txt.Text != "")
            {
                if (db.insertDB("INSERT INTO outcome_type VALUES('" + out_txt.Text + "')"))
                {
                    RefreshOutType();
                }
                else MessageBox.Show("هاذا المصروف موجود مسبقا");
            }
        }

        private void out_del_Click(object sender, EventArgs e)
        {
            try
            {
                string s = out_list.SelectedItems[0].Text;

                db.deleteDB("DELETE FROM outcome_type WHERE type='" + s + "'");
                RefreshOutType();
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ان تختار من القائمه");
            }
        }

        private void backup_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path=fbd.SelectedPath;
                if (db.BackUp(path))
                {
                    MessageBox.Show("تم عمل نسخه احطياطيه");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fbd = new OpenFileDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = fbd.FileName;
                if (db.Restore(path))
                {
                    MessageBox.Show("تم عمل نسخه احطياطيه");
                }
            }
        }

        private void add_bill_Click(object sender, EventArgs e)
        {

        }

        private void outcome_date_pic_ValueChanged(object sender, EventArgs e)
        {
            OutSearch();
        }

        private void date_combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutSearch();
        }

        private void outcome_type_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutSearch();
        }

        private void ref_out_Click(object sender, EventArgs e)
        {
            RefreshOut(out_query);
        }

        private void del_out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المصروف", "حذف مصروف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = outcome_gridview.SelectedCells[0].RowIndex;
                if (index >= 0)
                {
                    if (db.deleteDB("DELETE from outcome WHERE out_id=" + outcome_gridview.Rows[index].Cells[0].Value))
                    {
                        RefreshOut(out_query);
                        MessageBox.Show("تم حذف المصروف");
                    }
                }
            }
        }

        private void add_outome_Click(object sender, EventArgs e)
        {
            new AddOutcomeForm(this).Show();
        }

        private void add_color_Click(object sender, EventArgs e)
        {
            if (color_txt.Text != "")
            {
                if (db.insertDB("INSERT INTO color_type VALUES('" + color_txt.Text + "')"))
                {
                    RefreshColorType();
                }
                else MessageBox.Show("هاذا اللون موجود مسبقا");
            }
        }
        private void RefreshColorType()
        {
            color_list.Clear();
            foreach (string s in db.ListOF("SELECT * FROM color_type"))
            {
                color_list.Items.Add(s);
            }
            color_label.Text = "عدد الانواع " + color_list.Items.Count;
        }
        private void RefreshNeedItems()
        {
            need_item_list.Clear();
            foreach (string s in db.ListOF("SELECT * FROM items_type"))
                need_item_list.Items.Add(s);

        }
        private void delete_color_Click(object sender, EventArgs e)
        {
            try
            {
                string s = color_list.SelectedItems[0].Text;

                db.deleteDB("DELETE FROM color_type WHERE type='" + s + "'");
                RefreshColorType();
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ان تختار من القائمه");
            }
        }

        private void add_need_item_Click(object sender, EventArgs e)
        {
            if (need_item_name_txt.Text != "")
            {
                if (db.insertDB("INSERT INTO items_type VALUES ('" + need_item_name_txt.Text + "')"))
                    RefreshNeedItems();
            }
            else MessageBox.Show("الماده موجوده");
        }

        private void del_need_item_Click(object sender, EventArgs e)
        {
            try
            {
                string s = need_item_list.SelectedItems[0].Text;

                db.deleteDB("DELETE FROM items_type WHERE type='" + s + "'");
                RefreshOutType();
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ان تختار من القائمه");
            }
        }
    }
}
