using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab
{
    public partial class LoginForm : Form
    {
        SqlConnectionDB db;
        public LoginForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            db = new SqlConnectionDB();
            this.ActiveControl = user_txt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_txt.PasswordChar = '\0';
            } else password_txt.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string user_select = "select user_id,user_name,user_password from users where user_name='" + user_txt.Text+"'";
            DataSet data = new DataSet();
            db.selectDB(ref data,user_select);
            try
            {
                if (data.Tables[0].Rows.Count > 0)
                {
                    if (data.Tables[0].Rows[0][2].ToString() == password_txt.Text)
                    {
                        new MainForm(Convert.ToInt32(data.Tables[0].Rows[0][0].ToString())).Show();
                        this.Close();
                    }
                    else MessageBox.Show("الرقم السري خاطئ");
                }
                else MessageBox.Show("المستخدم غير موجود");
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
