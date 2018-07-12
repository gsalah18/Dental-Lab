using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Add_Forms
{
    public partial class AddteethesForm : Form
    {
        private AddBillForm form;
        private CheckBox[] checks = new CheckBox[49];
        private Label[] labels = new Label[49];
        private bool[] result = new bool[49];
        private bool[] r;
        private Color Dcolor;
        public AddteethesForm(AddBillForm form, bool[] r)
        {
            InitializeComponent();
            this.form = form;
            this.r = r;
        }
        private void AddteethesForm_Load(object sender, EventArgs e)
        {
            Dcolor = new Label().BackColor;
            Init();
            if (r != null)
            {
                for (int i = 0; i < r.Length; i++)
                    checks[i].Checked = r[i];
            }
            
        }



        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = checks[i].Checked;
            }
            form.SetTeethes(result);
            this.Close();
        }
        private void Change(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            int index = Convert.ToInt32(ch.Name.Substring(5));
            if (ch.Checked)
                labels[index].BackColor = Color.Blue;
            else if(!ch.Checked) labels[index].BackColor = Dcolor;
        }
        private void Init()
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = false;
                checks[i] = new CheckBox();
                checks[i].Checked = false;
                labels[i] = new Label();
            }
            /////////////////////////////////
            checks[11] = check11;
            checks[12] = check12;
            checks[13] = check13;
            checks[14] = check14;
            checks[15] = check15;
            checks[16] = check16;
            checks[17] = check17;
            checks[18] = check18;
            checks[21] = check21;
            checks[22] = check22;
            checks[23] = check23;
            checks[24] = check24;
            checks[25] = check25;
            checks[26] = check26;
            checks[27] = check27;
            checks[28] = check28;
            checks[31] = check31;
            checks[32] = check32;
            checks[33] = check33;
            checks[34] = check34;
            checks[35] = check35;
            checks[36] = check36;
            checks[37] = check37;
            checks[38] = check38;
            checks[41] = check41;
            checks[42] = check42;
            checks[43] = check43;
            checks[44] = check44;
            checks[45] = check45;
            checks[46] = check46;
            checks[47] = check47;
            checks[48] = check48;
            //////////////////////////////////////////
            labels[11] = label111;
            labels[12] = label121;
            labels[13] = label131;
            labels[14] = label141;
            labels[15] = label151;
            labels[16] = label161;
            labels[17] = label17;
            labels[18] = label18;
            labels[21] = label211;
            labels[22] = label221;
            labels[23] = label231;
            labels[24] = label241;
            labels[25] = label251;
            labels[26] = label261;
            labels[27] = label271;
            labels[28] = label281;
            labels[31] = label31;
            labels[32] = label32;
            labels[33] = label33;
            labels[34] = label34;
            labels[35] = label35;
            labels[36] = label36;
            labels[37] = label37;
            labels[38] = label38;
            labels[41] = label41;
            labels[42] = label42;
            labels[43] = label43;
            labels[44] = label44;
            labels[45] = label45;
            labels[46] = label46;
            labels[47] = label47;
            labels[48] = label48;
        }

        
    }
}
