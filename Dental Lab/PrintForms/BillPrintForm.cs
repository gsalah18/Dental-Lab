using Dental_Lab.Classes;
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
    public partial class BillPrintForm : Form
    {
        private Bill_Class bill;
        public BillPrintForm(Bill_Class bill)
        {
            InitializeComponent();
            this.bill = bill;
            
        }

        private void BillPrintForm_Load(object sender, EventArgs e)
        {
            billCrystalReports1.SetParameterValue("bill_id", bill.Id);
            billCrystalReports1.SetParameterValue("cust_name", bill.Customer);
            billCrystalReports1.SetParameterValue("rec_date", bill.RecDate);
            billCrystalReports1.SetParameterValue("delv_date", bill.DelvDate);
            billCrystalReports1.SetParameterValue("teethes", bill.Teethes);
            billCrystalReports1.SetParameterValue("type", bill.Type);
            billCrystalReports1.SetParameterValue("delv_state", bill.DelvState);
            billCrystalReports1.SetParameterValue("color", bill.Color);
            billCrystalReports1.SetParameterValue("price", bill.Price);
            billCrystalReports1.SetParameterValue("notes", bill.Notes);
            billCrystalReports1.SetParameterValue("today_date", bill.Today);
            crystalReportViewer1.ReportSource = billCrystalReports1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
