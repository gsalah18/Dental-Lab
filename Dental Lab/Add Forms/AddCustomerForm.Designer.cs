namespace Dental_Lab.Add_Forms
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.phone_list = new System.Windows.Forms.ListView();
            this.add_phone = new System.Windows.Forms.Button();
            this.del_phone = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(0, 339);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(549, 39);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "الغاء";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الزبون";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(102, 48);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(189, 20);
            this.name_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نوع الزبون";
            // 
            // type_combo
            // 
            this.type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Items.AddRange(new object[] {
            "طبيب",
            "مختبر",
            "زبون"});
            this.type_combo.Location = new System.Drawing.Point(102, 88);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(189, 21);
            this.type_combo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "البريد الالكتروني";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(103, 131);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(188, 20);
            this.email_txt.TabIndex = 9;
            // 
            // phone_list
            // 
            this.phone_list.Location = new System.Drawing.Point(338, 48);
            this.phone_list.MultiSelect = false;
            this.phone_list.Name = "phone_list";
            this.phone_list.RightToLeftLayout = true;
            this.phone_list.Size = new System.Drawing.Size(199, 132);
            this.phone_list.TabIndex = 10;
            this.phone_list.UseCompatibleStateImageBehavior = false;
            this.phone_list.View = System.Windows.Forms.View.List;
            // 
            // add_phone
            // 
            this.add_phone.Location = new System.Drawing.Point(338, 186);
            this.add_phone.Name = "add_phone";
            this.add_phone.Size = new System.Drawing.Size(75, 23);
            this.add_phone.TabIndex = 11;
            this.add_phone.Text = "اضافه";
            this.add_phone.UseVisualStyleBackColor = true;
            this.add_phone.Click += new System.EventHandler(this.add_phone_Click);
            // 
            // del_phone
            // 
            this.del_phone.Location = new System.Drawing.Point(464, 186);
            this.del_phone.Name = "del_phone";
            this.del_phone.Size = new System.Drawing.Size(73, 23);
            this.del_phone.TabIndex = 12;
            this.del_phone.Text = "حذف";
            this.del_phone.UseVisualStyleBackColor = true;
            this.del_phone.Click += new System.EventHandler(this.del_phone_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(141, 220);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 35);
            this.save.TabIndex = 13;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 378);
            this.Controls.Add(this.save);
            this.Controls.Add(this.del_phone);
            this.Controls.Add(this.add_phone);
            this.Controls.Add(this.phone_list);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCustomerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافه زبون";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.ListView phone_list;
        private System.Windows.Forms.Button add_phone;
        private System.Windows.Forms.Button del_phone;
        private System.Windows.Forms.Button save;
    }
}