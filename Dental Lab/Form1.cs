using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread th = new Thread(new ThreadStart(Splash));
            th.Start();
        }
        private void Splash()
        {
            Thread.Sleep(5000);
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    new LoginForm().Show();
                    this.Hide();
                }
                ));

            }
            
            
        
            
        }
    }
}
