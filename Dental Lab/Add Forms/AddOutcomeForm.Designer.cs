namespace Dental_Lab.Add_Forms
{
    partial class AddOutcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOutcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_pic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "المصروفات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 243);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(413, 46);
            this.close.TabIndex = 1;
            this.close.Text = "الغاء";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // type_combo
            // 
            this.type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Location = new System.Drawing.Point(178, 66);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(201, 21);
            this.type_combo.TabIndex = 2;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(178, 117);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(201, 20);
            this.price_txt.TabIndex = 3;
            this.price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(169, 202);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(81, 35);
            this.add.TabIndex = 4;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "نوع المصروف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "سعر المصروف";
            // 
            // date_pic
            // 
            this.date_pic.Location = new System.Drawing.Point(179, 157);
            this.date_pic.Name = "date_pic";
            this.date_pic.Size = new System.Drawing.Size(200, 20);
            this.date_pic.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "تاريخ المصروف";
            // 
            // AddOutcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_pic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOutcomeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه مصروف";
            this.Load += new System.EventHandler(this.AddOutcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_pic;
        private System.Windows.Forms.Label label4;
    }
}