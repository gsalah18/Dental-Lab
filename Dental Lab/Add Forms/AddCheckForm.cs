using Dental_Lab.Add_Forms;
using Dental_Lab.Classes;
using Dental_Lab.Show_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab
{
    public partial class AddCheckForm : Form
    {
        private AddPaymentForm payment;
        private Check_Class ch;
        private ShowPaymentForm form2;
        private int Payment_id;
        private SqlConnectionDB db;
        private DataSet data;
        private int ch_id;
        int cases;
        Image img=null;
        public AddCheckForm(AddPaymentForm payment,Check_Class ch)
        {
            InitializeComponent();
            db = new SqlConnectionDB();
            note_combo.SelectedIndex = 0;
            cases = 1;
            this.payment = payment;
            this.ch = ch;

        }
        public AddCheckForm(ShowPaymentForm form2,int payment_id)
        {
            InitializeComponent();
            db = new SqlConnectionDB();
            note_combo.SelectedIndex = 0;
            cases = 2;
            this.form2 = form2;
            this.Payment_id = payment_id;
            
        }
        public AddCheckForm(ShowPaymentForm form2,int ch_id, int temp)
        {
            
            InitializeComponent();
            db = new SqlConnectionDB();
            note_combo.SelectedIndex = 0;
            cases = 3;
            add.Text = "تعديل";
            this.Text = "تعديل الشيك";
            id_txt.Enabled = false;
            this.form2 = form2;
            this.ch_id = ch_id;
        }
        private void AddCheckForm_Load(object sender, EventArgs e)
        {

            if (cases == 1)
            {
                if (payment.customer_combo.SelectedIndex >= 0)
                    owner_txt.Text = payment.customer_combo.SelectedItem.ToString();
                if (ch != null)
                {
                    id_txt.Text = ch.Id + "";
                    bank_txt.Text = ch.Bank;
                    owner_txt.Text = ch.Owner;
                    date_pic.Value = ch.Delv_Date;
                    price_txt.Text = ch.Price + "";
                    note_combo.SelectedItem = ch.Notes;
                }
            }else if (cases == 3)
            {
                id_txt.Text = ch_id + "";
                data= new DataSet();
                db.selectDB(ref data, "SELECT * FROM checks WHERE ch_id=" + ch_id);
                bank_txt.Text = data.Tables[0].Rows[0][2].ToString();
                owner_txt.Text = data.Tables[0].Rows[0][3].ToString();
                date_pic.Value =Convert.ToDateTime(data.Tables[0].Rows[0][4].ToString());
                price_txt.Text = data.Tables[0].Rows[0][5].ToString();
                note_combo.SelectedItem = data.Tables[0].Rows[0][6].ToString();
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
                {
                if (cases == 1)
                {
                    
                    try
                    {
                        if (id_txt.Text.Length > 0 && bank_txt.Text.Length > 0 && owner_txt.Text.Length > 0
                             && price_txt.Text.Length > 0)
                        {
                            string id = id_txt.Text;
                            double price = Convert.ToDouble(price_txt.Text);
                            Check_Class checks = new Check_Class(id, bank_txt.Text, owner_txt.Text, date_pic.Value, price, note_combo.SelectedItem.ToString(),img);
                            payment.SetCheck(checks);
                            this.Close();
                        }
                        else MessageBox.Show("يجب ملئ جميع الخانات");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("لقد ادخلت قيمه خاظئه");
                    }
                }
                else if (cases == 2)
                {
                    try
                    {
                        if (id_txt.Text.Length > 0 && bank_txt.Text.Length > 0 && owner_txt.Text.Length > 0
                             && price_txt.Text.Length > 0)
                        {
                            
                            string id = id_txt.Text;
                            double price = Convert.ToDouble(price_txt.Text);
                            if (img == null)
                            {
                                string query = "INSERT INTO checks (ch_id,bill_id,ch_bank,ch_owner,ch_date,ch_price,ch_notes) VALUES('" + id + "','" + Payment_id + "' ,'" + bank_txt.Text + "'" +
                                            ",'" + owner_txt.Text + "','" + FormatDate(date_pic.Value) + "' ," + price + " ,'" + note_combo.SelectedItem + "')";
                                if (db.insertDB(query))
                                {

                                    MessageBox.Show("تم اضافه الشيك");
                                    form2.RefreshCheck();
                                    this.Close();
                                 }                           
                            }else
                            {
                                string query = "INSERT INTO checks  VALUES('" + id + "','" + Payment_id + "' ,'" + bank_txt.Text + "'" +
                                            ",'" + owner_txt.Text + "','" + FormatDate(date_pic.Value) + "' ," + price + " ,'" + note_combo.SelectedItem + "',@picture)";

                                Thread th = new Thread(() =>
                                {
                                    if (InvokeRequired)
                                    {

                                        this.Invoke(new MethodInvoker(delegate
                                        {
                                            if (db.insertImg(query,img))
                                            {

                                                MessageBox.Show("تم اضافه الشيك");
                                                form2.RefreshCheck();
                                                this.Close();
                                            }
                                        }));
                                    }

                                });
                                th.Start();
                            }
                            
                        }
                        else MessageBox.Show("يجب ملئ جميع الخانات");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("لقد ادخلت قيمه خاظئه");
                    }
                }
                else if (cases == 3)
                {
                    try
                    {
                        if (id_txt.Text.Length > 0 && bank_txt.Text.Length > 0 && owner_txt.Text.Length > 0
                             && price_txt.Text.Length > 0)
                        {
                            int id = Convert.ToInt32(id_txt.Text);
                            double price = Convert.ToDouble(price_txt.Text);
                            string query = "UPDATE checks SET ch_bank='" + bank_txt.Text + "'" +
                                        ",ch_owner='" + owner_txt.Text + "',ch_date='" + FormatDate(date_pic.Value) + "' ,ch_price=" + price + " ,ch_notes='" + note_combo.SelectedItem + "' WHERE ch_id=" + ch_id;
                            if (db.updateDB(query))
                            {
                                this.Close();
                                form2.RefreshCheck();
                            }
                        }
                        else MessageBox.Show("يجب ملئ جميع الخانات");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("لقد ادخلت قيمه خاظئه");
                    }
                }
            }
        }
     
         private string FormatDate(DateTime date)
        {
            string year = date.Year + "";
            string month = "";
            if (date.Month >= 10)
                month = date.Month + "";
            else month = "0" + date.Month;
            string day = date.Day + "";
            return year + "-" + month + "-" + day;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(ofd.FileName);
                Image thumb = img.GetThumbnailImage(400, 400, () => false, IntPtr.Zero);
                pictureBox1.Image = thumb;
            }
        }

       
    }
}
