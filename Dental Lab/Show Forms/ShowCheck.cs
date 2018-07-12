using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Show_Forms
{
    public partial class ShowCheck : Form
    {
        private int Id;
        private SqlConnectionDB db;
        private string user_role;
        public ShowCheck(int Id,string user_role)
        {
            InitializeComponent();
            this.Id = Id;
            this.user_role = user_role;
        }
        private void ShowCheck_Load(object sender, EventArgs e)
        {
            db = new SqlConnectionDB();
            RefreshCheck();
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RefreshCheck()
        {
            try
            {
                string select_query = "SELECT ch_id as 'رقم الشك',ch_bank as 'اسم البنك',ch_owner as 'صاحب الشك',ch_date 'تاريخ صرف الشك',ch_price as 'قيمه الشك',ch_notes 'ملاحظات' from checks where bill_id='" + Id + "'";
                DataSet data = new DataSet();
                db.selectDB(ref data, select_query);
                check_gridview.DataSource = data.Tables[0];
            }
            catch
            {
                this.Close();
            }
        }

        private void add_check_Click(object sender, EventArgs e)
        {
            //new AddCheckForm(this,Id,0).Show();
        }

        private void check_gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (user_role == "مسؤول")
            {
                int id = Convert.ToInt32(check_gridview.Rows[e.RowIndex].Cells[0].Value);
                //new AddCheckForm(this, id).Show();
            }
        }

        private void check_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int id = Convert.ToInt32(check_gridview.Rows[e.RowIndex].Cells[0].Value);
                    string query = "SELECT ch_pic from checks WHERE ch_id=" + id+" and ch_pic IS NOT NULL";
                    Image img = db.SelectIMG(query);
                    if (img != null)
                        new ShowPic(img).Show();
                    else MessageBox.Show("لا يوجد صوره");
                }
                catch
                {

                }
            }
        }
    }
}
