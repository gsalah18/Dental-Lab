namespace Dental_Lab
{
    partial class AddBillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBillForm));
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.payment_datepic = new System.Windows.Forms.DateTimePicker();
            this.payment_datepic_label = new System.Windows.Forms.Label();
            this.color_combo = new System.Windows.Forms.ComboBox();
            this.delv_state_combo = new System.Windows.Forms.ComboBox();
            this.warr_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.customer_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customer_combo = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.warrnity = new System.Windows.Forms.Button();
            this.cust_type_combo = new System.Windows.Forms.ComboBox();
            this.teethes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teethes_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Highlight;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 665);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(1008, 46);
            this.close.TabIndex = 0;
            this.close.Text = "الغاء";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "اضافه فاتوره";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1008, 613);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.payment_datepic);
            this.panel2.Controls.Add(this.payment_datepic_label);
            this.panel2.Controls.Add(this.color_combo);
            this.panel2.Controls.Add(this.delv_state_combo);
            this.panel2.Controls.Add(this.warr_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.id_txt);
            this.panel2.Controls.Add(this.notes_txt);
            this.panel2.Controls.Add(this.customer_label);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.customer_combo);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.warrnity);
            this.panel2.Controls.Add(this.cust_type_combo);
            this.panel2.Controls.Add(this.teethes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teethes_txt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.price_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.type_combo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(429, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 613);
            this.panel2.TabIndex = 26;
            // 
            // payment_datepic
            // 
            this.payment_datepic.Location = new System.Drawing.Point(48, 192);
            this.payment_datepic.Name = "payment_datepic";
            this.payment_datepic.Size = new System.Drawing.Size(200, 20);
            this.payment_datepic.TabIndex = 30;
            this.payment_datepic.Visible = false;
            // 
            // payment_datepic_label
            // 
            this.payment_datepic_label.AutoSize = true;
            this.payment_datepic_label.Location = new System.Drawing.Point(254, 198);
            this.payment_datepic_label.Name = "payment_datepic_label";
            this.payment_datepic_label.Size = new System.Drawing.Size(72, 13);
            this.payment_datepic_label.TabIndex = 29;
            this.payment_datepic_label.Text = "تاريخ  الاستلام";
            this.payment_datepic_label.Visible = false;
            // 
            // color_combo
            // 
            this.color_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.color_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.color_combo.FormattingEnabled = true;
            this.color_combo.Location = new System.Drawing.Point(307, 244);
            this.color_combo.Name = "color_combo";
            this.color_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.color_combo.Size = new System.Drawing.Size(157, 21);
            this.color_combo.TabIndex = 28;
            // 
            // delv_state_combo
            // 
            this.delv_state_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delv_state_combo.FormattingEnabled = true;
            this.delv_state_combo.Items.AddRange(new object[] {
            "لم يسلم",
            "تم التسليم",
            "لاغي"});
            this.delv_state_combo.Location = new System.Drawing.Point(331, 369);
            this.delv_state_combo.Name = "delv_state_combo";
            this.delv_state_combo.Size = new System.Drawing.Size(134, 21);
            this.delv_state_combo.TabIndex = 27;
            // 
            // warr_txt
            // 
            this.warr_txt.Enabled = false;
            this.warr_txt.Location = new System.Drawing.Point(307, 420);
            this.warr_txt.Name = "warr_txt";
            this.warr_txt.Size = new System.Drawing.Size(61, 20);
            this.warr_txt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم الفاتوره";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(340, 7);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(125, 20);
            this.id_txt.TabIndex = 0;
            this.id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notes_txt
            // 
            this.notes_txt.Location = new System.Drawing.Point(132, 463);
            this.notes_txt.Multiline = true;
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.Size = new System.Drawing.Size(333, 90);
            this.notes_txt.TabIndex = 24;
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Location = new System.Drawing.Point(495, 93);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(55, 13);
            this.customer_label.TabIndex = 3;
            this.customer_label.Text = "اسم الزبون";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ملاحظات";
            // 
            // customer_combo
            // 
            this.customer_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customer_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customer_combo.FormattingEnabled = true;
            this.customer_combo.Location = new System.Drawing.Point(260, 85);
            this.customer_combo.Name = "customer_combo";
            this.customer_combo.Size = new System.Drawing.Size(205, 21);
            this.customer_combo.TabIndex = 4;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(246, 559);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(87, 38);
            this.save.TabIndex = 22;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "نوع الزبون";
            // 
            // warrnity
            // 
            this.warrnity.Location = new System.Drawing.Point(390, 417);
            this.warrnity.Name = "warrnity";
            this.warrnity.Size = new System.Drawing.Size(75, 23);
            this.warrnity.TabIndex = 21;
            this.warrnity.Text = "اضافه كفاله";
            this.warrnity.UseVisualStyleBackColor = true;
            this.warrnity.Click += new System.EventHandler(this.warrnity_Click);
            // 
            // cust_type_combo
            // 
            this.cust_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cust_type_combo.FormattingEnabled = true;
            this.cust_type_combo.Items.AddRange(new object[] {
            "طبيب",
            "مختبر",
            "زبون"});
            this.cust_type_combo.Location = new System.Drawing.Point(260, 46);
            this.cust_type_combo.Name = "cust_type_combo";
            this.cust_type_combo.Size = new System.Drawing.Size(205, 21);
            this.cust_type_combo.TabIndex = 6;
            this.cust_type_combo.SelectedIndexChanged += new System.EventHandler(this.cust_type_combo_SelectedIndexChanged);
            // 
            // teethes
            // 
            this.teethes.Location = new System.Drawing.Point(340, 129);
            this.teethes.Name = "teethes";
            this.teethes.Size = new System.Drawing.Size(125, 31);
            this.teethes.TabIndex = 7;
            this.teethes.Text = "ارقام الاسنان";
            this.teethes.UseVisualStyleBackColor = true;
            this.teethes.Click += new System.EventHandler(this.teethes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "عدد الاسنان";
            // 
            // teethes_txt
            // 
            this.teethes_txt.Enabled = false;
            this.teethes_txt.Location = new System.Drawing.Point(364, 192);
            this.teethes_txt.Name = "teethes_txt";
            this.teethes_txt.Size = new System.Drawing.Size(100, 20);
            this.teethes_txt.TabIndex = 9;
            this.teethes_txt.Text = "0";
            this.teethes_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.teethes_txt.TextChanged += new System.EventHandler(this.teethes_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "حال التسليم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "اللون";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(364, 328);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 20);
            this.price_txt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "السعر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "النوع";
            // 
            // type_combo
            // 
            this.type_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.type_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Location = new System.Drawing.Point(307, 289);
            this.type_combo.Name = "type_combo";
            this.type_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_combo.Size = new System.Drawing.Size(157, 21);
            this.type_combo.TabIndex = 14;
            this.type_combo.SelectedIndexChanged += new System.EventHandler(this.type_combo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Dental_Lab.Properties.Resources._18679235_1862163304104155_936319956_n;
            this.pictureBox1.Location = new System.Drawing.Point(50, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBillForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافه فاتوره";
            this.Load += new System.EventHandler(this.AddBillForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.ComboBox cust_type_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button teethes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teethes_txt;
        private System.Windows.Forms.TextBox notes_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button warrnity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox warr_txt;
        public System.Windows.Forms.ComboBox customer_combo;
        private System.Windows.Forms.ComboBox delv_state_combo;
        private System.Windows.Forms.ComboBox color_combo;
        private System.Windows.Forms.DateTimePicker payment_datepic;
        private System.Windows.Forms.Label payment_datepic_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}