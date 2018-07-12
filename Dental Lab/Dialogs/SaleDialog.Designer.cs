namespace Dental_Lab.Dialogs
{
    partial class SaleDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDialog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cash_radio = new System.Windows.Forms.RadioButton();
            this.percentage_radio = new System.Windows.Forms.RadioButton();
            this.sale_txt = new System.Windows.Forms.TextBox();
            this.sale_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cash_radio);
            this.groupBox1.Controls.Add(this.percentage_radio);
            this.groupBox1.Location = new System.Drawing.Point(27, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع الخصم";
            // 
            // cash_radio
            // 
            this.cash_radio.AutoSize = true;
            this.cash_radio.Location = new System.Drawing.Point(97, 42);
            this.cash_radio.Name = "cash_radio";
            this.cash_radio.Size = new System.Drawing.Size(58, 17);
            this.cash_radio.TabIndex = 1;
            this.cash_radio.TabStop = true;
            this.cash_radio.Text = "نقدي $";
            this.cash_radio.UseVisualStyleBackColor = true;
            // 
            // percentage_radio
            // 
            this.percentage_radio.AutoSize = true;
            this.percentage_radio.Location = new System.Drawing.Point(94, 19);
            this.percentage_radio.Name = "percentage_radio";
            this.percentage_radio.Size = new System.Drawing.Size(61, 17);
            this.percentage_radio.TabIndex = 0;
            this.percentage_radio.TabStop = true;
            this.percentage_radio.Text = "مئوي %";
            this.percentage_radio.UseVisualStyleBackColor = true;
            // 
            // sale_txt
            // 
            this.sale_txt.Location = new System.Drawing.Point(93, 189);
            this.sale_txt.Name = "sale_txt";
            this.sale_txt.Size = new System.Drawing.Size(100, 20);
            this.sale_txt.TabIndex = 1;
            this.sale_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sale_btn
            // 
            this.sale_btn.Location = new System.Drawing.Point(109, 234);
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(75, 23);
            this.sale_btn.TabIndex = 2;
            this.sale_btn.Text = "اخصم";
            this.sale_btn.UseVisualStyleBackColor = true;
            this.sale_btn.Click += new System.EventHandler(this.sale_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تاريخ الخصم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "قيمه الخصم";
            // 
            // SaleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sale_btn);
            this.Controls.Add(this.sale_txt);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cash_radio;
        private System.Windows.Forms.RadioButton percentage_radio;
        private System.Windows.Forms.TextBox sale_txt;
        private System.Windows.Forms.Button sale_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}