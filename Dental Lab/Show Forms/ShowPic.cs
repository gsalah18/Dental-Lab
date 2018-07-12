using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab.Show_Forms
{
    public partial class ShowPic : Form
    {
        private Image img;
        public ShowPic(Image img)
        {
            InitializeComponent();
            this.img = img;
            pictureBox1.Image = this.img;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPic_Load(object sender, EventArgs e)
        {

        }
    }
}
