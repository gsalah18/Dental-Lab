namespace Dental_Lab.Show_Forms
{
    partial class ShowCustBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCustBills));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datefrom_pic = new System.Windows.Forms.DateTimePicker();
            this.dateto_pic = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cust_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_container = new System.Windows.Forms.TabControl();
            this.bills_tab = new System.Windows.Forms.TabPage();
            this.bill_girdview = new System.Windows.Forms.DataGridView();
            this.payments_tab = new System.Windows.Forms.TabPage();
            this.payment_gridview = new System.Windows.Forms.DataGridView();
            this.debits_tab = new System.Windows.Forms.TabPage();
            this.debits_gridview = new System.Windows.Forms.DataGridView();
            this.discounts_tab = new System.Windows.Forms.TabPage();
            this.discount_gridview = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.add_payment_btn = new System.Windows.Forms.Button();
            this.debt_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.final_total_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.total_paid_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sale_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_container.SuspendLayout();
            this.bills_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_girdview)).BeginInit();
            this.payments_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_gridview)).BeginInit();
            this.debits_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debits_gridview)).BeginInit();
            this.discounts_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discount_gridview)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 178);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.datefrom_pic);
            this.panel5.Controls.Add(this.dateto_pic);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1350, 85);
            this.panel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "الى";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(582, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "من";
            // 
            // datefrom_pic
            // 
            this.datefrom_pic.Location = new System.Drawing.Point(398, 34);
            this.datefrom_pic.Name = "datefrom_pic";
            this.datefrom_pic.Size = new System.Drawing.Size(200, 20);
            this.datefrom_pic.TabIndex = 7;
            this.datefrom_pic.ValueChanged += new System.EventHandler(this.datefrom_pic_ValueChanged);
            // 
            // dateto_pic
            // 
            this.dateto_pic.Location = new System.Drawing.Point(179, 33);
            this.dateto_pic.Name = "dateto_pic";
            this.dateto_pic.Size = new System.Drawing.Size(200, 20);
            this.dateto_pic.TabIndex = 5;
            this.dateto_pic.ValueChanged += new System.EventHandler(this.dateto_pic_ValueChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.date_label);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.cust_label);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1121, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 85);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "التاريخ:";
            // 
            // date_label
            // 
            this.date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(0, 15);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(154, 20);
            this.date_label.TabIndex = 3;
            this.date_label.Text = "label3";
            this.date_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "الساده : ";
            // 
            // cust_label
            // 
            this.cust_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_label.Location = new System.Drawing.Point(0, 43);
            this.cust_label.Name = "cust_label";
            this.cust_label.Size = new System.Drawing.Size(154, 25);
            this.cust_label.TabIndex = 1;
            this.cust_label.Text = "label2";
            this.cust_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1350, 87);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Dental_Lab.Properties.Resources.the_cover1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.close);
            this.panel7.Controls.Add(this.print);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1350, 43);
            this.panel7.TabIndex = 2;
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Left;
            this.close.Location = new System.Drawing.Point(0, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 43);
            this.close.TabIndex = 2;
            this.close.Text = "الغاء";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // print
            // 
            this.print.Dock = System.Windows.Forms.DockStyle.Right;
            this.print.Location = new System.Drawing.Point(1268, 0);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(82, 43);
            this.print.TabIndex = 1;
            this.print.Text = "طباعه";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 44);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tab_container);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 489);
            this.panel1.TabIndex = 5;
            // 
            // tab_container
            // 
            this.tab_container.Controls.Add(this.bills_tab);
            this.tab_container.Controls.Add(this.payments_tab);
            this.tab_container.Controls.Add(this.debits_tab);
            this.tab_container.Controls.Add(this.discounts_tab);
            this.tab_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_container.Location = new System.Drawing.Point(0, 0);
            this.tab_container.Name = "tab_container";
            this.tab_container.RightToLeftLayout = true;
            this.tab_container.SelectedIndex = 0;
            this.tab_container.Size = new System.Drawing.Size(1350, 386);
            this.tab_container.TabIndex = 6;
            // 
            // bills_tab
            // 
            this.bills_tab.Controls.Add(this.bill_girdview);
            this.bills_tab.Location = new System.Drawing.Point(4, 22);
            this.bills_tab.Name = "bills_tab";
            this.bills_tab.Padding = new System.Windows.Forms.Padding(3);
            this.bills_tab.Size = new System.Drawing.Size(1342, 360);
            this.bills_tab.TabIndex = 0;
            this.bills_tab.Text = "فواتير";
            this.bills_tab.UseVisualStyleBackColor = true;
            // 
            // bill_girdview
            // 
            this.bill_girdview.AllowUserToAddRows = false;
            this.bill_girdview.AllowUserToDeleteRows = false;
            this.bill_girdview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bill_girdview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.bill_girdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_girdview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_girdview.Location = new System.Drawing.Point(3, 3);
            this.bill_girdview.MultiSelect = false;
            this.bill_girdview.Name = "bill_girdview";
            this.bill_girdview.ReadOnly = true;
            this.bill_girdview.Size = new System.Drawing.Size(1336, 354);
            this.bill_girdview.TabIndex = 8;
            // 
            // payments_tab
            // 
            this.payments_tab.Controls.Add(this.payment_gridview);
            this.payments_tab.Location = new System.Drawing.Point(4, 22);
            this.payments_tab.Name = "payments_tab";
            this.payments_tab.Padding = new System.Windows.Forms.Padding(3);
            this.payments_tab.Size = new System.Drawing.Size(1342, 360);
            this.payments_tab.TabIndex = 1;
            this.payments_tab.Text = "دفعات";
            this.payments_tab.UseVisualStyleBackColor = true;
            // 
            // payment_gridview
            // 
            this.payment_gridview.AllowUserToAddRows = false;
            this.payment_gridview.AllowUserToDeleteRows = false;
            this.payment_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.payment_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment_gridview.Location = new System.Drawing.Point(3, 3);
            this.payment_gridview.MultiSelect = false;
            this.payment_gridview.Name = "payment_gridview";
            this.payment_gridview.ReadOnly = true;
            this.payment_gridview.Size = new System.Drawing.Size(1336, 354);
            this.payment_gridview.TabIndex = 8;
            // 
            // debits_tab
            // 
            this.debits_tab.Controls.Add(this.debits_gridview);
            this.debits_tab.Location = new System.Drawing.Point(4, 22);
            this.debits_tab.Name = "debits_tab";
            this.debits_tab.Size = new System.Drawing.Size(1342, 360);
            this.debits_tab.TabIndex = 2;
            this.debits_tab.Text = "ديون";
            this.debits_tab.UseVisualStyleBackColor = true;
            // 
            // debits_gridview
            // 
            this.debits_gridview.AllowUserToAddRows = false;
            this.debits_gridview.AllowUserToDeleteRows = false;
            this.debits_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.debits_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.debits_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debits_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debits_gridview.Location = new System.Drawing.Point(0, 0);
            this.debits_gridview.MultiSelect = false;
            this.debits_gridview.Name = "debits_gridview";
            this.debits_gridview.ReadOnly = true;
            this.debits_gridview.Size = new System.Drawing.Size(1342, 360);
            this.debits_gridview.TabIndex = 8;
            // 
            // discounts_tab
            // 
            this.discounts_tab.Controls.Add(this.discount_gridview);
            this.discounts_tab.Location = new System.Drawing.Point(4, 22);
            this.discounts_tab.Name = "discounts_tab";
            this.discounts_tab.Size = new System.Drawing.Size(1342, 360);
            this.discounts_tab.TabIndex = 3;
            this.discounts_tab.Text = "خصومات";
            this.discounts_tab.UseVisualStyleBackColor = true;
            // 
            // discount_gridview
            // 
            this.discount_gridview.AllowUserToAddRows = false;
            this.discount_gridview.AllowUserToDeleteRows = false;
            this.discount_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.discount_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.discount_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discount_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discount_gridview.Location = new System.Drawing.Point(0, 0);
            this.discount_gridview.MultiSelect = false;
            this.discount_gridview.Name = "discount_gridview";
            this.discount_gridview.ReadOnly = true;
            this.discount_gridview.Size = new System.Drawing.Size(1342, 360);
            this.discount_gridview.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.add_payment_btn);
            this.panel8.Controls.Add(this.debt_label);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.final_total_label);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.total_paid_label);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.sale_label);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.change);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.total);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 386);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1350, 103);
            this.panel8.TabIndex = 5;
            // 
            // add_payment_btn
            // 
            this.add_payment_btn.Location = new System.Drawing.Point(1232, 39);
            this.add_payment_btn.Name = "add_payment_btn";
            this.add_payment_btn.Size = new System.Drawing.Size(75, 23);
            this.add_payment_btn.TabIndex = 13;
            this.add_payment_btn.Text = "اضافه دفعه";
            this.add_payment_btn.UseVisualStyleBackColor = true;
            this.add_payment_btn.Click += new System.EventHandler(this.add_payment_btn_Click);
            // 
            // debt_label
            // 
            this.debt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debt_label.Location = new System.Drawing.Point(24, 23);
            this.debt_label.Name = "debt_label";
            this.debt_label.Size = new System.Drawing.Size(93, 20);
            this.debt_label.TabIndex = 12;
            this.debt_label.Text = "0";
            this.debt_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "دين سابق";
            // 
            // final_total_label
            // 
            this.final_total_label.AutoSize = true;
            this.final_total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_total_label.Location = new System.Drawing.Point(221, 54);
            this.final_total_label.Name = "final_total_label";
            this.final_total_label.Size = new System.Drawing.Size(57, 20);
            this.final_total_label.TabIndex = 10;
            this.final_total_label.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "المبلغ المتبقي";
            // 
            // total_paid_label
            // 
            this.total_paid_label.AutoSize = true;
            this.total_paid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_paid_label.Location = new System.Drawing.Point(485, 54);
            this.total_paid_label.Name = "total_paid_label";
            this.total_paid_label.Size = new System.Drawing.Size(57, 20);
            this.total_paid_label.TabIndex = 8;
            this.total_paid_label.Text = "label8";
            this.total_paid_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(547, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "مجموع الدفعات";
            // 
            // sale_label
            // 
            this.sale_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_label.Location = new System.Drawing.Point(185, 20);
            this.sale_label.Name = "sale_label";
            this.sale_label.Size = new System.Drawing.Size(93, 20);
            this.sale_label.TabIndex = 6;
            this.sale_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "قيمه الخصم";
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(398, 20);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 4;
            this.change.Text = "الخصم";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ــــــــــــــــــــــــــــــــــ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "التوقيع : ";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(479, 23);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(62, 20);
            this.total.TabIndex = 1;
            this.total.Text = "label3";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "سعر الفواتير";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "جرد جساب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowCustBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowCustBills";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كشف فواتير";
            this.Load += new System.EventHandler(this.ShowCustBills_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tab_container.ResumeLayout(false);
            this.bills_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_girdview)).EndInit();
            this.payments_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payment_gridview)).EndInit();
            this.debits_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.debits_gridview)).EndInit();
            this.discounts_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discount_gridview)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cust_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateto_pic;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tab_container;
        private System.Windows.Forms.TabPage bills_tab;
        private System.Windows.Forms.TabPage payments_tab;
        private System.Windows.Forms.TabPage debits_tab;
        private System.Windows.Forms.TabPage discounts_tab;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label debt_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label final_total_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total_paid_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sale_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView bill_girdview;
        private System.Windows.Forms.DataGridView payment_gridview;
        private System.Windows.Forms.DataGridView debits_gridview;
        private System.Windows.Forms.DataGridView discount_gridview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datefrom_pic;
        private System.Windows.Forms.Button add_payment_btn;
        private System.Windows.Forms.Button button1;
    }
}