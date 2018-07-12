using Dental_Lab.Show_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Dialogs
{
    public partial class SaleDialog : Form
    {
        private double money;
        private ShowCustBills form;
        public SaleDialog(ShowCustBills form,double money,DateTime date)
        {
            InitializeComponent();
            this.money = money;
            this.form = form;
            dateTimePicker1.Value = date;
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double sale = Convert.ToDouble(sale_txt.Text);
                if (percentage_radio.Checked)
                {
                    double result = 0;
                    String discount=sale+"%";
                    if (money >= 0)
                        result = money - (money * (sale/100));
                    else result = money + (money * (sale / 100));
                    if (MessageBox.Show("المبلغ بعد الخصم "+result+" هل تريد الخصم؟","تاكيد الخصم",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        form.SetSale(result,dateTimePicker1.Value, discount);
                        this.Close();
                    }
                }
                else if (cash_radio.Checked)
                {
                    double result = 0;
                    String discount = sale + "$";
                    if (money >= 0)
                        result = money - sale;
                    else result = money + sale;
                    if (MessageBox.Show("المبلغ بعد الخصم " + result + " هل تريد الخصم؟", "تاكيد الخصم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        form.SetSale(result,dateTimePicker1.Value,discount);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("يجب ان تختار نوع من الخصم");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ادخل قيمه خصم حقيقه");
            }
              
        }

    }
}
