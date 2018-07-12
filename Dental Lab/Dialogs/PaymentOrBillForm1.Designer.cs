namespace Dental_Lab.Others
{
    partial class PaymentOrBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOrBillForm));
            this.AddBill = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.debt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBill
            // 
            this.AddBill.Location = new System.Drawing.Point(34, 42);
            this.AddBill.Name = "AddBill";
            this.AddBill.Size = new System.Drawing.Size(89, 23);
            this.AddBill.TabIndex = 0;
            this.AddBill.Text = "اضافه فاتوره";
            this.AddBill.UseVisualStyleBackColor = true;
            this.AddBill.Click += new System.EventHandler(this.AddBill_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 119);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(339, 33);
            this.close.TabIndex = 2;
            this.close.Text = "اغلق";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // debt
            // 
            this.debt.Location = new System.Drawing.Point(213, 42);
            this.debt.Name = "debt";
            this.debt.Size = new System.Drawing.Size(89, 23);
            this.debt.TabIndex = 3;
            this.debt.Text = "اضافه دين سابق";
            this.debt.UseVisualStyleBackColor = true;
            this.debt.Click += new System.EventHandler(this.debt_Click);
            // 
            // PaymentOrBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 152);
            this.Controls.Add(this.debt);
            this.Controls.Add(this.close);
            this.Controls.Add(this.AddBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentOrBillForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتوره ام دفعه";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBill;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button debt;
    }
}