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
    public partial class CustPrintForm : Form
    {
        private CustBillDataSet data;
        private string total,customer,total_cash,sale,left,debt;

        private void crystalReportViewer1_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show("تم الطباعه");
        }

        public CustPrintForm(CustBillDataSet data,string total,string customer,string total_cash,string sale,string left,string debt)
        { 
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.data = data;
            this.customer = customer;
            this.total = total;
            this.total_cash = total_cash;
            this.sale = sale;
            this.left = left;
            this.debt = debt;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustPrintForm_Load(object sender, EventArgs e)
        {
            custCrystalReport1.SetDataSource(data);
            custCrystalReport1.SetParameterValue("total", total);
            custCrystalReport1.SetParameterValue("customer", customer);
            custCrystalReport1.SetParameterValue("today", FormatDate(DateTime.Today));
            custCrystalReport1.SetParameterValue("total_cash",total_cash);
            custCrystalReport1.SetParameterValue("sale", sale);
            custCrystalReport1.SetParameterValue("left", left);
            custCrystalReport1.SetParameterValue("debt", debt);
            crystalReportViewer1.ReportSource = custCrystalReport1;
        }
        private string FormatDate(DateTime today)
        {
            return today.Year + "/" + today.Month + "/" + today.Day;
        }
    }
}
