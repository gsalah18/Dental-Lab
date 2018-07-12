namespace Dental_Lab.Show_Forms
{
    partial class ShowPaymentForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.dataGridView_check = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_cust = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_check)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Dental_Lab.Properties.Resources.the_cover1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(0, 443);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(768, 45);
            this.close_btn.TabIndex = 29;
            this.close_btn.Text = "اغلاق";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dataGridView_check
            // 
            this.dataGridView_check.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_check.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_check.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_check.Location = new System.Drawing.Point(0, 217);
            this.dataGridView_check.Name = "dataGridView_check";
            this.dataGridView_check.Size = new System.Drawing.Size(768, 226);
            this.dataGridView_check.TabIndex = 30;
            this.dataGridView_check.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_check_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "الرقم التسلسلي";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(104, 96);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 13);
            this.label_id.TabIndex = 32;
            this.label_id.Text = "label2";
            // 
            // label_cust
            // 
            this.label_cust.AutoSize = true;
            this.label_cust.Location = new System.Drawing.Point(104, 128);
            this.label_cust.Name = "label_cust";
            this.label_cust.Size = new System.Drawing.Size(35, 13);
            this.label_cust.TabIndex = 34;
            this.label_cust.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "اسم الزبون";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(268, 96);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(35, 13);
            this.label_price.TabIndex = 36;
            this.label_price.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "قيمه الكاش";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(268, 128);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(35, 13);
            this.label_date.TabIndex = 38;
            this.label_date.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "تاريخ الدفعه";
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(104, 164);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(35, 13);
            this.label_note.TabIndex = 40;
            this.label_note.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "ملاحظات";
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(693, 188);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 41;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(611, 187);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 42;
            this.add_btn.Text = "اضافه";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // ShowPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 488);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_cust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_check);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShowPaymentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPaymentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView dataGridView_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_cust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
    }
}