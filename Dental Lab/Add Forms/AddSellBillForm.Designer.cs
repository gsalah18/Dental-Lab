namespace Dental_Lab.Main_Forms
{
    partial class AddSellBillForm
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
            this.seller_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seller_combo
            // 
            this.seller_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.seller_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.seller_combo.FormattingEnabled = true;
            this.seller_combo.Location = new System.Drawing.Point(96, 56);
            this.seller_combo.Name = "seller_combo";
            this.seller_combo.Size = new System.Drawing.Size(135, 21);
            this.seller_combo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم التاجر";
            // 
            // items
            // 
            this.items.Location = new System.Drawing.Point(96, 109);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(99, 23);
            this.items.TabIndex = 2;
            this.items.Text = "اضافه الاغراض";
            this.items.UseVisualStyleBackColor = true;
            this.items.Click += new System.EventHandler(this.items_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "السعر الكلي";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(96, 160);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(99, 20);
            this.price_txt.TabIndex = 4;
            this.price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 282);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(331, 42);
            this.close.TabIndex = 5;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(120, 209);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddSellBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 324);
            this.Controls.Add(this.add);
            this.Controls.Add(this.close);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seller_combo);
            this.Name = "AddSellBillForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه فاتوره";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seller_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button add;
    }
}