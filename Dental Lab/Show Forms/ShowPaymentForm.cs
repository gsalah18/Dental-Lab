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
    public partial class ShowPaymentForm : Form
    {
        private int id;
        private SqlConnectionDB db;
        public ShowPaymentForm(int id)
        {
            InitializeComponent();
            this.id = id;
            this.db =new SqlConnectionDB();
            RefreshPay();
            RefreshCheck();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshPay()
        {
            String query = "SELECT c.cust_name,p.pay_price,p.pay_date,p.pay_note FROM payments p, customer c WHERE pay_id='"+id+"' AND c.cust_id=p.cust_id";
            DataSet data = new DataSet();
            db.selectDB(ref data, query);
            label_id.Text = id + "";
            label_cust.Text = data.Tables[0].Rows[0][0].ToString();
            label_price.Text = data.Tables[0].Rows[0][1].ToString();
            label_date.Text = data.Tables[0].Rows[0][2].ToString();
            label_note.Text = data.Tables[0].Rows[0][3].ToString();
        }
        public void RefreshCheck() {
            String query = "SELECT ch_id as 'رقم الشك' , ch_bank as 'اسم البنك' , ch_owner as 'صاحب الشك' , ch_date as 'تاريخ الشك', ch_price as 'قيمه الشك' , ch_notes as 'ملاحطات' FROM checks WHERE bill_id='" + id+"' ";
            DataSet data = new DataSet();
            db.selectDB(ref data, query);
            dataGridView_check.DataSource = data.Tables[0];
        }

        private void dataGridView_check_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView_check.Rows[e.RowIndex].Cells[0].Value);
                string query = "SELECT ch_pic from checks WHERE ch_id=" + id + " and ch_pic IS NOT NULL";
                Image img = db.SelectIMG(query);
                if (img != null)
                    new ShowPic(img).Show();
                else MessageBox.Show("لا يوجد صوره");
            }
            catch
            {

            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            new AddCheckForm(this,Convert.ToInt32(label_id.Text)).Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_check.SelectedCells.Count > 0)
            {
                if (dataGridView_check.SelectedCells.Count == 1)
                {
                    
                    int id = Convert.ToInt32(dataGridView_check.Rows[dataGridView_check.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                    new AddCheckForm(this, id, 1).Show();
                }
                else MessageBox.Show("يجب ان تختار شك واحد لتعديله");
            }
            else MessageBox.Show("يجب ا تختار احد الشكات");
        }
    }
}
