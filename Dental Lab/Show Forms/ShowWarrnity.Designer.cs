namespace Dental_Lab.Show_Forms
{
    partial class ShowWarrnity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowWarrnity));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.warr_period_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delv_label = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_label = new System.Windows.Forms.Label();
            this.customer_show_label = new System.Windows.Forms.Label();
            this.customer_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bill_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 35);
            this.panel1.TabIndex = 1;
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Left;
            this.close.Location = new System.Drawing.Point(0, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 35);
            this.close.TabIndex = 1;
            this.close.Text = "اغلاق";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // print
            // 
            this.print.Dock = System.Windows.Forms.DockStyle.Right;
            this.print.Location = new System.Drawing.Point(269, 0);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 35);
            this.print.TabIndex = 0;
            this.print.Text = "طباعه";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "مده الكفاله:";
            // 
            // warr_period_label
            // 
            this.warr_period_label.AutoSize = true;
            this.warr_period_label.Location = new System.Drawing.Point(122, 226);
            this.warr_period_label.Name = "warr_period_label";
            this.warr_period_label.Size = new System.Drawing.Size(35, 13);
            this.warr_period_label.TabIndex = 3;
            this.warr_period_label.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "تاريخ التسليم :";
            // 
            // delv_label
            // 
            this.delv_label.AutoSize = true;
            this.delv_label.Location = new System.Drawing.Point(122, 202);
            this.delv_label.Name = "delv_label";
            this.delv_label.Size = new System.Drawing.Size(35, 13);
            this.delv_label.TabIndex = 6;
            this.delv_label.Text = "label4";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(122, 315);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(86, 29);
            this.edit.TabIndex = 8;
            this.edit.Text = "تعديل الكفاله";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Dental_Lab.Properties.Resources.the_cover1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم المريض :";
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Location = new System.Drawing.Point(122, 119);
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(35, 13);
            this.patient_label.TabIndex = 10;
            this.patient_label.Text = "label4";
            // 
            // customer_show_label
            // 
            this.customer_show_label.AutoSize = true;
            this.customer_show_label.Location = new System.Drawing.Point(40, 145);
            this.customer_show_label.Name = "customer_show_label";
            this.customer_show_label.Size = new System.Drawing.Size(62, 13);
            this.customer_show_label.TabIndex = 11;
            this.customer_show_label.Text = "اسم الطبيب :";
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Location = new System.Drawing.Point(122, 145);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(35, 13);
            this.customer_label.TabIndex = 12;
            this.customer_label.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "رقم الفاتوره :";
            // 
            // bill_label
            // 
            this.bill_label.AutoSize = true;
            this.bill_label.Location = new System.Drawing.Point(122, 174);
            this.bill_label.Name = "bill_label";
            this.bill_label.Size = new System.Drawing.Size(35, 13);
            this.bill_label.TabIndex = 14;
            this.bill_label.Text = "label5";
            // 
            // ShowWarrnity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 385);
            this.Controls.Add(this.bill_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customer_label);
            this.Controls.Add(this.customer_show_label);
            this.Controls.Add(this.patient_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delv_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warr_period_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowWarrnity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الكفاله";
            this.Load += new System.EventHandler(this.ShowWarrnity_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warr_period_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label delv_label;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patient_label;
        private System.Windows.Forms.Label customer_show_label;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bill_label;
    }
}