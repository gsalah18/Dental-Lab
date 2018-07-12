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
    public partial class WarrPrintForm : Form
    {
        private Warrnity_Class warrnity;
        public WarrPrintForm(Warrnity_Class warrnity)
        {
            InitializeComponent();
            this.warrnity = warrnity;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarrPrintForm_Load(object sender, EventArgs e)
        {
            warrCrystalReport1.SetParameterValue("patient", warrnity.Patient);
            warrCrystalReport1.SetParameterValue("customer_type", warrnity.DocType);
            warrCrystalReport1.SetParameterValue("customer", warrnity.Doctor);
            warrCrystalReport1.SetParameterValue("bill", warrnity.Bill);
            warrCrystalReport1.SetParameterValue("warr_period", warrnity.Period);
            warrCrystalReport1.SetParameterValue("warr_start", warrnity.StartDate);
            crystalReportViewer1.ReportSource = warrCrystalReport1;
        }
    }
}
