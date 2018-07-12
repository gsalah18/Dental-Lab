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

namespace Dental_Lab.Others
{
    public partial class PaymentOrBillForm : Form
    {
        private MainForm form;
        public PaymentOrBillForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPayment_Click(object sender, EventArgs e)
        {
            new AddPaymentForm(form).Show();
            this.Close();
        }

        private void AddBill_Click(object sender, EventArgs e)
        {
            
            new AddBillForm(form).Show();
            this.Close();
        }

        private void debt_Click(object sender, EventArgs e)
        {
            new AddDebitForm(form).Show();
            this.Close();
        }
    }
}
