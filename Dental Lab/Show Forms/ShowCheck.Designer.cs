namespace Dental_Lab.Show_Forms
{
    partial class ShowCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check_gridview = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_check = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_check)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "الشيكات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(0, 318);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(786, 41);
            this.close.TabIndex = 1;
            this.close.Text = "اغلاق";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.check_gridview);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 269);
            this.panel1.TabIndex = 2;
            // 
            // check_gridview
            // 
            this.check_gridview.AllowUserToAddRows = false;
            this.check_gridview.AllowUserToDeleteRows = false;
            this.check_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.check_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.check_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.check_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check_gridview.Location = new System.Drawing.Point(0, 59);
            this.check_gridview.MultiSelect = false;
            this.check_gridview.Name = "check_gridview";
            this.check_gridview.ReadOnly = true;
            this.check_gridview.Size = new System.Drawing.Size(786, 210);
            this.check_gridview.TabIndex = 3;
            this.check_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.check_gridview_CellClick);
            this.check_gridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.check_gridview_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_check);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 59);
            this.panel2.TabIndex = 2;
            // 
            // add_check
            // 
            this.add_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_check.Dock = System.Windows.Forms.DockStyle.Right;
            this.add_check.Image = global::Dental_Lab.Properties.Resources.ic_add_black_24dp_1x;
            this.add_check.Location = new System.Drawing.Point(740, 0);
            this.add_check.Name = "add_check";
            this.add_check.Size = new System.Drawing.Size(46, 59);
            this.add_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_check.TabIndex = 0;
            this.add_check.TabStop = false;
            this.add_check.Click += new System.EventHandler(this.add_check_Click);
            // 
            // ShowCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowCheck";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشكات";
            this.Load += new System.EventHandler(this.ShowCheck_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.add_check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView check_gridview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox add_check;
    }
}