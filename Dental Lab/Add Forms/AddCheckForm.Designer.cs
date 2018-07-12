namespace Dental_Lab
{
    partial class AddCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCheckForm));
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bank_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.owner_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_pic = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.note_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(179, 29);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 0;
            this.id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم الشك";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم البنك";
            // 
            // bank_txt
            // 
            this.bank_txt.Location = new System.Drawing.Point(179, 68);
            this.bank_txt.Name = "bank_txt";
            this.bank_txt.Size = new System.Drawing.Size(135, 20);
            this.bank_txt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "صاحب الشك";
            // 
            // owner_txt
            // 
            this.owner_txt.Location = new System.Drawing.Point(179, 109);
            this.owner_txt.Name = "owner_txt";
            this.owner_txt.Size = new System.Drawing.Size(135, 20);
            this.owner_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ صرف الشك";
            // 
            // date_pic
            // 
            this.date_pic.Location = new System.Drawing.Point(180, 151);
            this.date_pic.Name = "date_pic";
            this.date_pic.Size = new System.Drawing.Size(200, 20);
            this.date_pic.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "قيمه الشيك";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(180, 186);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 20);
            this.price_txt.TabIndex = 10;
            this.price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "فعال؟";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(180, 318);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 39);
            this.add.TabIndex = 13;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 370);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(398, 41);
            this.close.TabIndex = 15;
            this.close.Text = "الغاء";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // note_combo
            // 
            this.note_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.note_combo.FormattingEnabled = true;
            this.note_combo.Items.AddRange(new object[] {
            "نعم",
            "لا"});
            this.note_combo.Location = new System.Drawing.Point(180, 223);
            this.note_combo.Name = "note_combo";
            this.note_combo.Size = new System.Drawing.Size(100, 21);
            this.note_combo.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "اضافه صوره";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(261, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // AddCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.note_combo);
            this.Controls.Add(this.close);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_pic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.owner_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bank_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCheckForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه شيك";
            this.Load += new System.EventHandler(this.AddCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bank_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox owner_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox note_combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}