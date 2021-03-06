﻿namespace Dental_Lab.Add_Forms
{
    partial class AddDebitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.customer_label = new System.Windows.Forms.Label();
            this.customer_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cust_type_combo = new System.Windows.Forms.ComboBox();
            this.price_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_debit_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "اضافه دين سابق";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Highlight;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 319);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(456, 46);
            this.close.TabIndex = 4;
            this.close.Text = "الغاء";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Location = new System.Drawing.Point(40, 122);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(55, 13);
            this.customer_label.TabIndex = 13;
            this.customer_label.Text = "اسم الزبون";
            // 
            // customer_combo
            // 
            this.customer_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customer_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customer_combo.FormattingEnabled = true;
            this.customer_combo.Location = new System.Drawing.Point(101, 119);
            this.customer_combo.Name = "customer_combo";
            this.customer_combo.Size = new System.Drawing.Size(205, 21);
            this.customer_combo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "نوع الزبون";
            // 
            // cust_type_combo
            // 
            this.cust_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cust_type_combo.FormattingEnabled = true;
            this.cust_type_combo.Items.AddRange(new object[] {
            "طبيب",
            "مختبر",
            "زبون"});
            this.cust_type_combo.Location = new System.Drawing.Point(101, 92);
            this.cust_type_combo.Name = "cust_type_combo";
            this.cust_type_combo.Size = new System.Drawing.Size(205, 21);
            this.cust_type_combo.TabIndex = 16;
            this.cust_type_combo.SelectedIndexChanged += new System.EventHandler(this.cust_type_combo_SelectedIndexChanged);
            // 
            // price_text
            // 
            this.price_text.Location = new System.Drawing.Point(101, 157);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(100, 20);
            this.price_text.TabIndex = 12;
            this.price_text.Text = "0";
            this.price_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "قيمه الكاش";
            // 
            // add_debit_btn
            // 
            this.add_debit_btn.Location = new System.Drawing.Point(179, 269);
            this.add_debit_btn.Name = "add_debit_btn";
            this.add_debit_btn.Size = new System.Drawing.Size(75, 23);
            this.add_debit_btn.TabIndex = 17;
            this.add_debit_btn.Text = "اضافه";
            this.add_debit_btn.UseVisualStyleBackColor = true;
            this.add_debit_btn.Click += new System.EventHandler(this.add_debit_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "تاريخ الدين";
            // 
            // AddDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_debit_btn);
            this.Controls.Add(this.customer_label);
            this.Controls.Add(this.customer_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cust_type_combo);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Name = "AddDebitForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "AddDebitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label customer_label;
        public System.Windows.Forms.ComboBox customer_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cust_type_combo;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_debit_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}