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
    public partial class Form2 : Form
    {
        int x;
        int y;
        
        public Form2()
        {
            InitializeComponent();
        }


        private void timerACW_Tick(object sender, EventArgs e)
        {
            x = btn.Left;
            y = btn.Top;

            if (x == 0 && (y >= 0 && y < (this.ClientSize.Height - btn.Height)))
            {
                btn.Left = 0;
                if (((this.ClientSize.Height - btn.Height) - y) < 10)
                    btn.Top = this.ClientSize.Height - btn.Height;
                else
                    btn.Top = y + 10;
            }
            else if ((x >= 0 && (x < this.ClientSize.Width - btn.Width)) && y == this.ClientSize.Height - btn.Height)
            {
                btn.Top = this.ClientSize.Height - btn.Height;
                if (((this.ClientSize.Width - btn.Width) - x) < 10)
                    btn.Left = this.ClientSize.Width - btn.Width;
                else
                    btn.Left = x + 10;
            }
            else if ((x == this.ClientSize.Width - btn.Width) && (y > 0 && (y <= this.ClientSize.Height - btn.Height)))
            {
                btn.Left = this.ClientSize.Width - btn.Width;
                if(y - 0 < 10)
                    btn.Top = this.ClientSize.Height - btn.Height;
                else
                    btn.Top = y - 10;
            }
            
            else
            {
                if (x - 0 < 10)
                    btn.Left = 0;
                else
                {                 
                    btn.Left = x - 10;
                }
                btn.Top = 0;
            }
           
        }

        private void timerCW_Tick(object sender, EventArgs e)
        {
            x = btn.Left;
            y = btn.Top;

            if ((x >= 0 && (x < this.ClientSize.Width - btn.Width)) && y == 0)
            {
                btn.Top = 0;
                if (((this.ClientSize.Width - btn.Width) - x) < 10)
                    btn.Left = this.ClientSize.Width - btn.Width;
                else
                    btn.Left = x + 10;
            }

            else if ((x == this.ClientSize.Width - btn.Width) && (y >= 0 && (y < this.ClientSize.Height - btn.Height)))
            {
                btn.Left = this.ClientSize.Width - btn.Width;
                if(((this.ClientSize.Height - btn.Height) - y) < 10)
                    btn.Top = this.ClientSize.Height - btn.Height;
                else
                    btn.Top = y + 10;
            }

            else if ((x > 0 && (x <= this.ClientSize.Width - btn.Width)) && y == this.ClientSize.Height - btn.Height)
            {
                btn.Top = this.ClientSize.Height - btn.Height;
                if (x - 0 < 10)
                    btn.Left = 0;
                else
                    btn.Left = x - 10;
            }

            else
            {
                btn.Left = 0;
                if (y - 0 < 10)
                    btn.Top = 0;
                else
                    btn.Top = y - 10;

            }

            
            
            
        }


        private void SelectDirection(object sender, EventArgs e)
        {
            if (btn.BackColor == Color.Blue)
            {
                timerACW.Enabled = radbtnACW.Checked;
                timerCW.Enabled = radbtnCW.Checked;             
            }
                

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Red;

                if (timerACW.Enabled)
                {
                    timerACW.Enabled = false;
                }
                else
                {
                    timerCW.Enabled = false;
                }
            }
            else
            {
                btn.BackColor = Color.Blue;

                if (radbtnCW.Checked)
                    timerCW.Enabled = true;
                else
                    timerACW.Enabled = true;

            }
        }

        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radbtnCW.Checked = true;
            if (btn.BackColor == Color.Blue)
            {
                timerCW.Enabled = true;
                timerACW.Enabled = false;               
            }
        }

        private void counterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radbtnACW.Checked = true;
            if (btn.BackColor == Color.Blue)
            {
                timerACW.Enabled = true;
                timerCW.Enabled = false;               
            }
        }
    }
}
                                                                                                                    
