namespace Dental_Lab.Add_Forms
{
    partial class AddNeedForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الماده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "كميه الماده";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(35, 61);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.ShortcutsEnabled = false;
            this.amount_txt.Size = new System.Drawing.Size(100, 20);
            this.amount_txt.TabIndex = 3;
            this.amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(84, 118);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 4;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 178);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(257, 33);
            this.close.TabIndex = 5;
            this.close.Text = "الغاء";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // name_combo
            // 
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Location = new System.Drawing.Point(26, 31);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(121, 21);
            this.name_combo.TabIndex = 6;
            // 
            // AddNeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 211);
            this.Controls.Add(this.name_combo);
            this.Controls.Add(this.close);
            this.Controls.Add(this.add);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه نواقص";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox name_combo;
    }
}