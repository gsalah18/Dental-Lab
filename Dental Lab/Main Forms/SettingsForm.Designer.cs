namespace Dental_Lab.Main_Forms
{
    partial class SettingsForm
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
            this.close = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.types = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teeth_gridview = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.add_teeth = new System.Windows.Forms.Button();
            this.teethe_count = new System.Windows.Forms.Label();
            this.teeth_txt = new System.Windows.Forms.TextBox();
            this.del_teeth = new System.Windows.Forms.Button();
            this.accounts = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.role_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.account_gridview = new System.Windows.Forms.DataGridView();
            this.backup_tap = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.outcomes_type = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.out_add = new System.Windows.Forms.Button();
            this.out_count = new System.Windows.Forms.Label();
            this.out_txt = new System.Windows.Forms.TextBox();
            this.out_del = new System.Windows.Forms.Button();
            this.out_list = new System.Windows.Forms.ListView();
            this.outcome = new System.Windows.Forms.TabPage();
            this.outcome_gridview = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.del_out = new System.Windows.Forms.Button();
            this.ref_out = new System.Windows.Forms.Button();
            this.outcome_type_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date_combo2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outcome_date_pic = new System.Windows.Forms.DateTimePicker();
            this.add_outome = new System.Windows.Forms.PictureBox();
            this.colortab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.add_color = new System.Windows.Forms.Button();
            this.color_label = new System.Windows.Forms.Label();
            this.color_txt = new System.Windows.Forms.TextBox();
            this.delete_color = new System.Windows.Forms.Button();
            this.color_list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.needitemstab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.add_need_item = new System.Windows.Forms.Button();
            this.need_item_name_txt = new System.Windows.Forms.TextBox();
            this.del_need_item = new System.Windows.Forms.Button();
            this.need_item_list = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.types.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teeth_gridview)).BeginInit();
            this.accounts.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account_gridview)).BeginInit();
            this.backup_tap.SuspendLayout();
            this.outcomes_type.SuspendLayout();
            this.panel3.SuspendLayout();
            this.outcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outcome_gridview)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_outome)).BeginInit();
            this.colortab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.needitemstab.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 677);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(1008, 34);
            this.close.TabIndex = 0;
            this.close.Text = "العوده";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.types);
            this.tabControl1.Controls.Add(this.accounts);
            this.tabControl1.Controls.Add(this.backup_tap);
            this.tabControl1.Controls.Add(this.outcomes_type);
            this.tabControl1.Controls.Add(this.outcome);
            this.tabControl1.Controls.Add(this.colortab);
            this.tabControl1.Controls.Add(this.needitemstab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 642);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // types
            // 
            this.types.Controls.Add(this.panel1);
            this.types.Location = new System.Drawing.Point(4, 34);
            this.types.Name = "types";
            this.types.Padding = new System.Windows.Forms.Padding(3);
            this.types.Size = new System.Drawing.Size(1000, 673);
            this.types.TabIndex = 0;
            this.types.Text = "انواع الاسنان";
            this.types.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teeth_gridview);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.price_txt);
            this.panel1.Controls.Add(this.add_teeth);
            this.panel1.Controls.Add(this.teethe_count);
            this.panel1.Controls.Add(this.teeth_txt);
            this.panel1.Controls.Add(this.del_teeth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(502, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 667);
            this.panel1.TabIndex = 5;
            // 
            // teeth_gridview
            // 
            this.teeth_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teeth_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.teeth_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teeth_gridview.Dock = System.Windows.Forms.DockStyle.Right;
            this.teeth_gridview.Location = new System.Drawing.Point(314, 0);
            this.teeth_gridview.Name = "teeth_gridview";
            this.teeth_gridview.Size = new System.Drawing.Size(181, 667);
            this.teeth_gridview.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "سعر السن";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "نوع السن";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(20, 79);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 20);
            this.price_txt.TabIndex = 5;
            this.price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_teeth
            // 
            this.add_teeth.Location = new System.Drawing.Point(230, 120);
            this.add_teeth.Name = "add_teeth";
            this.add_teeth.Size = new System.Drawing.Size(75, 23);
            this.add_teeth.TabIndex = 1;
            this.add_teeth.Text = "اضافه";
            this.add_teeth.UseVisualStyleBackColor = true;
            this.add_teeth.Click += new System.EventHandler(this.add_teeth_Click);
            // 
            // teethe_count
            // 
            this.teethe_count.AutoSize = true;
            this.teethe_count.Location = new System.Drawing.Point(217, 16);
            this.teethe_count.Name = "teethe_count";
            this.teethe_count.Size = new System.Drawing.Size(59, 13);
            this.teethe_count.TabIndex = 4;
            this.teethe_count.Text = "عدد الانواع ";
            // 
            // teeth_txt
            // 
            this.teeth_txt.Location = new System.Drawing.Point(153, 80);
            this.teeth_txt.Name = "teeth_txt";
            this.teeth_txt.Size = new System.Drawing.Size(152, 20);
            this.teeth_txt.TabIndex = 2;
            // 
            // del_teeth
            // 
            this.del_teeth.Location = new System.Drawing.Point(230, 191);
            this.del_teeth.Name = "del_teeth";
            this.del_teeth.Size = new System.Drawing.Size(75, 23);
            this.del_teeth.TabIndex = 3;
            this.del_teeth.Text = "حذف";
            this.del_teeth.UseVisualStyleBackColor = true;
            this.del_teeth.Click += new System.EventHandler(this.del_teeth_Click);
            // 
            // accounts
            // 
            this.accounts.Controls.Add(this.panel2);
            this.accounts.Controls.Add(this.account_gridview);
            this.accounts.Location = new System.Drawing.Point(4, 34);
            this.accounts.Name = "accounts";
            this.accounts.Padding = new System.Windows.Forms.Padding(3);
            this.accounts.Size = new System.Drawing.Size(1000, 673);
            this.accounts.TabIndex = 1;
            this.accounts.Text = "الحسابات";
            this.accounts.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.role_combo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.password_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.name_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.username_txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.id_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(82, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 667);
            this.panel2.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(109, 316);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(81, 28);
            this.clear.TabIndex = 13;
            this.clear.Text = "مسح";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(12, 268);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 28);
            this.delete.TabIndex = 12;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(109, 268);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 28);
            this.update.TabIndex = 11;
            this.update.Text = "تعديل";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(210, 268);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(81, 28);
            this.add.TabIndex = 10;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // role_combo
            // 
            this.role_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_combo.FormattingEnabled = true;
            this.role_combo.Items.AddRange(new object[] {
            "مسؤول",
            "عادي"});
            this.role_combo.Location = new System.Drawing.Point(56, 214);
            this.role_combo.Name = "role_combo";
            this.role_combo.Size = new System.Drawing.Size(152, 21);
            this.role_combo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "دور المستخدم";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(25, 167);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(183, 20);
            this.password_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "الرقم السري";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(24, 116);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(183, 20);
            this.name_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "الاسم الكامل";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(67, 68);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(141, 20);
            this.username_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم المستخدم";
            // 
            // id_txt
            // 
            this.id_txt.Enabled = false;
            this.id_txt.Location = new System.Drawing.Point(97, 25);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(81, 20);
            this.id_txt.TabIndex = 1;
            this.id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "رقم المستخدم";
            // 
            // account_gridview
            // 
            this.account_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.account_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.account_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.account_gridview.Dock = System.Windows.Forms.DockStyle.Right;
            this.account_gridview.Location = new System.Drawing.Point(395, 3);
            this.account_gridview.MultiSelect = false;
            this.account_gridview.Name = "account_gridview";
            this.account_gridview.ReadOnly = true;
            this.account_gridview.Size = new System.Drawing.Size(602, 667);
            this.account_gridview.TabIndex = 0;
            this.account_gridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.account_gridview_CellDoubleClick);
            // 
            // backup_tap
            // 
            this.backup_tap.Controls.Add(this.button1);
            this.backup_tap.Controls.Add(this.backup);
            this.backup_tap.Location = new System.Drawing.Point(4, 34);
            this.backup_tap.Name = "backup_tap";
            this.backup_tap.Padding = new System.Windows.Forms.Padding(3);
            this.backup_tap.Size = new System.Drawing.Size(1000, 673);
            this.backup_tap.TabIndex = 3;
            this.backup_tap.Text = "النسخه الاحطياطيه";
            this.backup_tap.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "استرجاع نسخه احطياطيه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(648, 196);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(138, 23);
            this.backup.TabIndex = 3;
            this.backup.Text = "عمل نسخه احطياطيه";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // outcomes_type
            // 
            this.outcomes_type.Controls.Add(this.panel3);
            this.outcomes_type.Controls.Add(this.out_list);
            this.outcomes_type.Location = new System.Drawing.Point(4, 34);
            this.outcomes_type.Name = "outcomes_type";
            this.outcomes_type.Size = new System.Drawing.Size(1000, 673);
            this.outcomes_type.TabIndex = 2;
            this.outcomes_type.Text = "انواع المصروفات";
            this.outcomes_type.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.out_add);
            this.panel3.Controls.Add(this.out_count);
            this.panel3.Controls.Add(this.out_txt);
            this.panel3.Controls.Add(this.out_del);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(574, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 673);
            this.panel3.TabIndex = 7;
            // 
            // out_add
            // 
            this.out_add.Location = new System.Drawing.Point(153, 118);
            this.out_add.Name = "out_add";
            this.out_add.Size = new System.Drawing.Size(75, 23);
            this.out_add.TabIndex = 1;
            this.out_add.Text = "اضافه";
            this.out_add.UseVisualStyleBackColor = true;
            this.out_add.Click += new System.EventHandler(this.out_add_Click);
            // 
            // out_count
            // 
            this.out_count.AutoSize = true;
            this.out_count.Location = new System.Drawing.Point(153, 32);
            this.out_count.Name = "out_count";
            this.out_count.Size = new System.Drawing.Size(59, 13);
            this.out_count.TabIndex = 4;
            this.out_count.Text = "عدد الانواع ";
            // 
            // out_txt
            // 
            this.out_txt.Location = new System.Drawing.Point(76, 78);
            this.out_txt.Name = "out_txt";
            this.out_txt.Size = new System.Drawing.Size(152, 20);
            this.out_txt.TabIndex = 2;
            // 
            // out_del
            // 
            this.out_del.Location = new System.Drawing.Point(153, 189);
            this.out_del.Name = "out_del";
            this.out_del.Size = new System.Drawing.Size(75, 23);
            this.out_del.TabIndex = 3;
            this.out_del.Text = "حذف";
            this.out_del.UseVisualStyleBackColor = true;
            this.out_del.Click += new System.EventHandler(this.out_del_Click);
            // 
            // out_list
            // 
            this.out_list.Dock = System.Windows.Forms.DockStyle.Right;
            this.out_list.Location = new System.Drawing.Point(822, 0);
            this.out_list.MultiSelect = false;
            this.out_list.Name = "out_list";
            this.out_list.RightToLeftLayout = true;
            this.out_list.Size = new System.Drawing.Size(178, 673);
            this.out_list.TabIndex = 6;
            this.out_list.UseCompatibleStateImageBehavior = false;
            this.out_list.View = System.Windows.Forms.View.List;
            // 
            // outcome
            // 
            this.outcome.Controls.Add(this.outcome_gridview);
            this.outcome.Controls.Add(this.panel4);
            this.outcome.Location = new System.Drawing.Point(4, 34);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(1000, 673);
            this.outcome.TabIndex = 4;
            this.outcome.Text = "المصروفات";
            this.outcome.UseVisualStyleBackColor = true;
            // 
            // outcome_gridview
            // 
            this.outcome_gridview.AllowUserToAddRows = false;
            this.outcome_gridview.AllowUserToDeleteRows = false;
            this.outcome_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outcome_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.outcome_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outcome_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outcome_gridview.Location = new System.Drawing.Point(0, 59);
            this.outcome_gridview.MultiSelect = false;
            this.outcome_gridview.Name = "outcome_gridview";
            this.outcome_gridview.ReadOnly = true;
            this.outcome_gridview.Size = new System.Drawing.Size(1000, 614);
            this.outcome_gridview.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.del_out);
            this.panel4.Controls.Add(this.ref_out);
            this.panel4.Controls.Add(this.outcome_type_combo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.date_combo2);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.outcome_date_pic);
            this.panel4.Controls.Add(this.add_outome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 59);
            this.panel4.TabIndex = 4;
            // 
            // del_out
            // 
            this.del_out.Dock = System.Windows.Forms.DockStyle.Right;
            this.del_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_out.Location = new System.Drawing.Point(879, 0);
            this.del_out.Name = "del_out";
            this.del_out.Size = new System.Drawing.Size(75, 59);
            this.del_out.TabIndex = 9;
            this.del_out.Text = "حذف";
            this.del_out.UseVisualStyleBackColor = true;
            this.del_out.Click += new System.EventHandler(this.del_out_Click);
            // 
            // ref_out
            // 
            this.ref_out.Dock = System.Windows.Forms.DockStyle.Left;
            this.ref_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref_out.Location = new System.Drawing.Point(0, 0);
            this.ref_out.Name = "ref_out";
            this.ref_out.Size = new System.Drawing.Size(75, 59);
            this.ref_out.TabIndex = 8;
            this.ref_out.Text = "تحديث";
            this.ref_out.UseVisualStyleBackColor = true;
            this.ref_out.Click += new System.EventHandler(this.ref_out_Click);
            // 
            // outcome_type_combo
            // 
            this.outcome_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outcome_type_combo.FormattingEnabled = true;
            this.outcome_type_combo.Items.AddRange(new object[] {
            "الكل"});
            this.outcome_type_combo.Location = new System.Drawing.Point(81, 22);
            this.outcome_type_combo.Name = "outcome_type_combo";
            this.outcome_type_combo.Size = new System.Drawing.Size(133, 21);
            this.outcome_type_combo.TabIndex = 6;
            this.outcome_type_combo.SelectedIndexChanged += new System.EventHandler(this.outcome_type_combo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "البحث من خلال النوع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "البحث حسب";
            // 
            // date_combo2
            // 
            this.date_combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.date_combo2.FormattingEnabled = true;
            this.date_combo2.Items.AddRange(new object[] {
            "الكل",
            "السنه",
            "السنه والشهر",
            "السنه والشهر واليوم"});
            this.date_combo2.Location = new System.Drawing.Point(348, 19);
            this.date_combo2.Name = "date_combo2";
            this.date_combo2.Size = new System.Drawing.Size(133, 21);
            this.date_combo2.TabIndex = 3;
            this.date_combo2.SelectedIndexChanged += new System.EventHandler(this.date_combo2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(768, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "البحث من خلال التاريخ";
            // 
            // outcome_date_pic
            // 
            this.outcome_date_pic.Location = new System.Drawing.Point(552, 19);
            this.outcome_date_pic.Name = "outcome_date_pic";
            this.outcome_date_pic.Size = new System.Drawing.Size(200, 20);
            this.outcome_date_pic.TabIndex = 1;
            this.outcome_date_pic.ValueChanged += new System.EventHandler(this.outcome_date_pic_ValueChanged);
            // 
            // add_outome
            // 
            this.add_outome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_outome.Dock = System.Windows.Forms.DockStyle.Right;
            this.add_outome.Image = global::Dental_Lab.Properties.Resources.ic_add_black_24dp_1x;
            this.add_outome.Location = new System.Drawing.Point(954, 0);
            this.add_outome.Name = "add_outome";
            this.add_outome.Size = new System.Drawing.Size(46, 59);
            this.add_outome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_outome.TabIndex = 0;
            this.add_outome.TabStop = false;
            this.add_outome.Click += new System.EventHandler(this.add_outome_Click);
            // 
            // colortab
            // 
            this.colortab.Controls.Add(this.panel5);
            this.colortab.Controls.Add(this.color_list);
            this.colortab.Location = new System.Drawing.Point(4, 34);
            this.colortab.Name = "colortab";
            this.colortab.Padding = new System.Windows.Forms.Padding(3);
            this.colortab.Size = new System.Drawing.Size(1000, 673);
            this.colortab.TabIndex = 5;
            this.colortab.Text = "انواع الالوان";
            this.colortab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.add_color);
            this.panel5.Controls.Add(this.color_label);
            this.panel5.Controls.Add(this.color_txt);
            this.panel5.Controls.Add(this.delete_color);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(571, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 667);
            this.panel5.TabIndex = 9;
            // 
            // add_color
            // 
            this.add_color.Location = new System.Drawing.Point(153, 118);
            this.add_color.Name = "add_color";
            this.add_color.Size = new System.Drawing.Size(75, 23);
            this.add_color.TabIndex = 1;
            this.add_color.Text = "اضافه";
            this.add_color.UseVisualStyleBackColor = true;
            this.add_color.Click += new System.EventHandler(this.add_color_Click);
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(153, 32);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(59, 13);
            this.color_label.TabIndex = 4;
            this.color_label.Text = "عدد الانواع ";
            // 
            // color_txt
            // 
            this.color_txt.Location = new System.Drawing.Point(76, 78);
            this.color_txt.Name = "color_txt";
            this.color_txt.Size = new System.Drawing.Size(152, 20);
            this.color_txt.TabIndex = 2;
            // 
            // delete_color
            // 
            this.delete_color.Location = new System.Drawing.Point(153, 189);
            this.delete_color.Name = "delete_color";
            this.delete_color.Size = new System.Drawing.Size(75, 23);
            this.delete_color.TabIndex = 3;
            this.delete_color.Text = "حذف";
            this.delete_color.UseVisualStyleBackColor = true;
            this.delete_color.Click += new System.EventHandler(this.delete_color_Click);
            // 
            // color_list
            // 
            this.color_list.Dock = System.Windows.Forms.DockStyle.Right;
            this.color_list.Location = new System.Drawing.Point(819, 3);
            this.color_list.MultiSelect = false;
            this.color_list.Name = "color_list";
            this.color_list.RightToLeftLayout = true;
            this.color_list.Size = new System.Drawing.Size(178, 667);
            this.color_list.TabIndex = 8;
            this.color_list.UseCompatibleStateImageBehavior = false;
            this.color_list.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاعدادات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // needitemstab
            // 
            this.needitemstab.Controls.Add(this.panel6);
            this.needitemstab.Controls.Add(this.need_item_list);
            this.needitemstab.Location = new System.Drawing.Point(4, 34);
            this.needitemstab.Name = "needitemstab";
            this.needitemstab.Size = new System.Drawing.Size(1000, 604);
            this.needitemstab.TabIndex = 6;
            this.needitemstab.Text = "مواد النواقص";
            this.needitemstab.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.add_need_item);
            this.panel6.Controls.Add(this.need_item_name_txt);
            this.panel6.Controls.Add(this.del_need_item);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(574, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 604);
            this.panel6.TabIndex = 9;
            // 
            // add_need_item
            // 
            this.add_need_item.Location = new System.Drawing.Point(153, 118);
            this.add_need_item.Name = "add_need_item";
            this.add_need_item.Size = new System.Drawing.Size(75, 23);
            this.add_need_item.TabIndex = 1;
            this.add_need_item.Text = "اضافه";
            this.add_need_item.UseVisualStyleBackColor = true;
            this.add_need_item.Click += new System.EventHandler(this.add_need_item_Click);
            // 
            // need_item_name_txt
            // 
            this.need_item_name_txt.Location = new System.Drawing.Point(76, 78);
            this.need_item_name_txt.Name = "need_item_name_txt";
            this.need_item_name_txt.Size = new System.Drawing.Size(152, 20);
            this.need_item_name_txt.TabIndex = 2;
            // 
            // del_need_item
            // 
            this.del_need_item.Location = new System.Drawing.Point(153, 189);
            this.del_need_item.Name = "del_need_item";
            this.del_need_item.Size = new System.Drawing.Size(75, 23);
            this.del_need_item.TabIndex = 3;
            this.del_need_item.Text = "حذف";
            this.del_need_item.UseVisualStyleBackColor = true;
            this.del_need_item.Click += new System.EventHandler(this.del_need_item_Click);
            // 
            // need_item_list
            // 
            this.need_item_list.Dock = System.Windows.Forms.DockStyle.Right;
            this.need_item_list.Location = new System.Drawing.Point(822, 0);
            this.need_item_list.MultiSelect = false;
            this.need_item_list.Name = "need_item_list";
            this.need_item_list.RightToLeftLayout = true;
            this.need_item_list.Size = new System.Drawing.Size(178, 604);
            this.need_item_list.TabIndex = 8;
            this.need_item_list.UseCompatibleStateImageBehavior = false;
            this.need_item_list.View = System.Windows.Forms.View.List;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Name = "SettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه الاعدادات";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.types.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teeth_gridview)).EndInit();
            this.accounts.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.account_gridview)).EndInit();
            this.backup_tap.ResumeLayout(false);
            this.outcomes_type.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.outcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outcome_gridview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_outome)).EndInit();
            this.colortab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.needitemstab.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage types;
        private System.Windows.Forms.TabPage accounts;
        private System.Windows.Forms.Button del_teeth;
        private System.Windows.Forms.TextBox teeth_txt;
        private System.Windows.Forms.Button add_teeth;
        private System.Windows.Forms.Label teethe_count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox role_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TabPage outcomes_type;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button out_add;
        private System.Windows.Forms.Label out_count;
        private System.Windows.Forms.TextBox out_txt;
        private System.Windows.Forms.Button out_del;
        private System.Windows.Forms.ListView out_list;
        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.DataGridView account_gridview;
        private System.Windows.Forms.TabPage backup_tap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage outcome;
        private System.Windows.Forms.DataGridView outcome_gridview;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button del_out;
        private System.Windows.Forms.Button ref_out;
        private System.Windows.Forms.ComboBox outcome_type_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox date_combo2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker outcome_date_pic;
        private System.Windows.Forms.PictureBox add_outome;
        private System.Windows.Forms.DataGridView teeth_gridview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TabPage colortab;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button add_color;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.TextBox color_txt;
        private System.Windows.Forms.Button delete_color;
        private System.Windows.Forms.ListView color_list;
        private System.Windows.Forms.TabPage needitemstab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button add_need_item;
        private System.Windows.Forms.TextBox need_item_name_txt;
        private System.Windows.Forms.Button del_need_item;
        private System.Windows.Forms.ListView need_item_list;
    }
}