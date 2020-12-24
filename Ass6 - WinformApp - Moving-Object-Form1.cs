using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass6
{
    public partial class Form1 : Form
    {
        int count = 0;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                switch (count)
                {
                    case 0:
                        {
                            picBox1.Image = Properties.Resources.Tampa;
                            count = 1;
                            this.Text = "Tampa";
                            break;
                        }
                    case 1:
                        {
                            picBox1.Image = Properties.Resources.Orlando;
                            count = 2;
                            this.Text = "Orlando";
                            break;
                        }
                    case 2:
                        {
                            picBox1.Image = Properties.Resources.Miami;
                            count = 3;
                            this.Text = "Miami";
                            break;
                        }
                    case 3:
                        {
                            picBox1.Image = Properties.Resources.Jacksonville;
                            count = 0;
                            this.Text = "Jacksonville";
                            break;
                        }
                }
        }

        

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                timer1.Enabled = false;
                
            }
            else
            {
                timer1.Enabled = true;
                
            }
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Form2();
            f2.ShowDialog();
        }

        private void openNextFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox1_Click(sender, e);
        }

        private void freezePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            cb1.Checked = true;
        }

        private void unfreezePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cb1.Checked = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
