using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass5_vs
{
    public partial class Welcome : Form
    {
        Form1 f1;
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_DoubleClick(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.ShowDialog();
        }

       
    }
}
