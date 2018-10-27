using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.PrintForms
{
    public partial class PaymentPrintForm : Form
    {
        private PaymentDataSet data;
        private string customerName;
        public PaymentPrintForm(PaymentDataSet data, string customerName)
        {
            InitializeComponent();
            this.data = data;
            this.customerName = customerName;
        }

        private void PaymentPrintForm_Load(object sender, EventArgs e)
        {
            paymentCrystalReport1.SetDataSource(data);
            paymentCrystalReport1.SetParameterValue("cust_name", customerName);
            paymentCrystalReport1.SetParameterValue("today_date", FormatDate(DateTime.Today));
            crystalReportViewer1.ReportSource = paymentCrystalReport1;
        }

        private string FormatDate(DateTime today)
        {
            return today.Year + "/" + today.Month + "/" + today.Day;
        }

        private void paymentCrystalReport1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
