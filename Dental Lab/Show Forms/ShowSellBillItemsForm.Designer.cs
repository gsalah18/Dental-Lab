namespace Dental_Lab.Show_Forms
{
    partial class ShowSellBillItemsForm
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
            this.sell_bill_items_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sell_bill_items_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // sell_bill_items_gridview
            // 
            this.sell_bill_items_gridview.AllowUserToAddRows = false;
            this.sell_bill_items_gridview.AllowUserToDeleteRows = false;
            this.sell_bill_items_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sell_bill_items_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.sell_bill_items_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sell_bill_items_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sell_bill_items_gridview.Location = new System.Drawing.Point(0, 0);
            this.sell_bill_items_gridview.MultiSelect = false;
            this.sell_bill_items_gridview.Name = "sell_bill_items_gridview";
            this.sell_bill_items_gridview.ReadOnly = true;
            this.sell_bill_items_gridview.Size = new System.Drawing.Size(636, 272);
            this.sell_bill_items_gridview.TabIndex = 8;
            // 
            // ShowSellBillItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 272);
            this.Controls.Add(this.sell_bill_items_gridview);
            this.Name = "ShowSellBillItemsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الاغراض";
            this.Load += new System.EventHandler(this.ShowSellBillItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sell_bill_items_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sell_bill_items_gridview;
    }
}