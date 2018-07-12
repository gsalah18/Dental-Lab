using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Dental_Lab.Classes;
using Dental_Lab.Main_Forms;

namespace Dental_Lab.Dialogs
{
    public partial class SellBillItemsDialog : Form
    {
        private LinkedList<Items> list = new LinkedList<Items>();
        private LinkedList<string> data;
        private SqlConnectionDB db;
        private AddSellBillForm form;
        public SellBillItemsDialog(AddSellBillForm form)
        {
            InitializeComponent();
            db = new SqlConnectionDB();
            data = db.ListOF("SELECT * FROM items_type");
            this.form = form;
            int counts;
            while (true) {
                try
                {
                    counts = Convert.ToInt32(Interaction.InputBox("ادخل عدد الاغراض", "عدد الاغراض", "العدد", 200, 200));
                    break;
                } catch (FormatException)
                {
                    MessageBox.Show("ادخل عدد صحيح");
                }
            }
            int j = 0;
            #region
            for (int i = 0; i < counts; i++)
            {
                ComboBox comboBox1 = new ComboBox();
                Label label1 = new Label();
                Label label2 = new Label();
                TextBox textBox1 = new TextBox();
                TextBox textBox2 = new TextBox();
                Label label3 = new Label();
               
                // 
                // comboBox1
                // 
                comboBox1.FormattingEnabled = true;
                comboBox1.Location = new System.Drawing.Point(84, 86 + j);
                comboBox1.Name = "comboBox1";
                comboBox1.Size = new System.Drawing.Size(141, 21);
                comboBox1.TabIndex = 0;
                // 
                // label1
                // 
                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(25, 89 + j);
                label1.Name = "label1";
                label1.Size = new System.Drawing.Size(53, 13);
                label1.TabIndex = 1;
                label1.Text = "اسم الماده";
                // 
                // label2
                // 
                label2.AutoSize = true;
                label2.Location = new System.Drawing.Point(258, 89 + j);
                label2.Name = "label2";
                label2.Size = new System.Drawing.Size(29, 13);
                label2.TabIndex = 2;
                label2.Text = "العدد";
                // 
                // textBox1
                // 
                textBox1.Location = new System.Drawing.Point(303, 86 + j);
                textBox1.Name = "textBox1";
                textBox1.Size = new System.Drawing.Size(100, 20);
                textBox1.TabIndex = 3;
                textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // textBox2
                // 
                textBox2.Location = new System.Drawing.Point(467, 86 + j);
                textBox2.Name = "textBox2";
                textBox2.Size = new System.Drawing.Size(100, 20);
                textBox2.TabIndex = 5;
                textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // label3
                // 
                label3.AutoSize = true;
                label3.Location = new System.Drawing.Point(422, 89 + j);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(33, 13);
                label3.TabIndex = 4;
                label3.Text = "السعر";
                this.Controls.Add(comboBox1);
                this.Controls.Add(label1);
                this.Controls.Add(textBox1);
                this.Controls.Add(label2);
                this.Controls.Add(textBox2);
                this.Controls.Add(label3);
                foreach (string s in data)
                    comboBox1.Items.Add(s);
                list.AddLast(new Items
                {
                    item_combo = comboBox1,
                    count_txt = textBox1,
                    price_txt = textBox2
                });

                j +=50;
            }
            #endregion
        }

        private void save_Click(object sender, EventArgs e)
        {
            string[,] data= new string[list.Count,3];
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Convert.ToInt32(list.ElementAt(i).count_txt.Text);
                    Convert.ToDouble(list.ElementAt(i).price_txt.Text);
                    data[i, 0] = list.ElementAt(i).item_combo.Text;
                    data[i, 1] = list.ElementAt(i).count_txt.Text;
                    data[i, 2] = list.ElementAt(i).price_txt.Text;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ادخل ارقام صحيحه");
            }

            this.Close();
            form.SetList(data);
        }
    }
}
