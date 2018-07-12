namespace Dental_Lab.Dialogs
{
    partial class Delivery_Dialog
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
            this.delv_state_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delv_state_combo
            // 
            this.delv_state_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delv_state_combo.FormattingEnabled = true;
            this.delv_state_combo.Items.AddRange(new object[] {
            "لم يسلم",
            "تم التسليم",
            "لاغي"});
            this.delv_state_combo.Location = new System.Drawing.Point(114, 51);
            this.delv_state_combo.Name = "delv_state_combo";
            this.delv_state_combo.Size = new System.Drawing.Size(134, 21);
            this.delv_state_combo.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "حال التسليم";
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Location = new System.Drawing.Point(0, 132);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(446, 33);
            this.close.TabIndex = 30;
            this.close.Text = "اغلق";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(173, 92);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 31;
            this.change.Text = "تعديل";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Delivery_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 165);
            this.Controls.Add(this.change);
            this.Controls.Add(this.close);
            this.Controls.Add(this.delv_state_combo);
            this.Controls.Add(this.label8);
            this.Name = "Delivery_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery_Dialog";
            this.Load += new System.EventHandler(this.Delivery_Dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delv_state_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button change;
    }
}