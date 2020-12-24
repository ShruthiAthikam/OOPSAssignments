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
    
    public partial class Form1 : Form
    {
        Random r = new Random();
        int btn_xCount = 0;
        int winCount = 0;
        int lostCount = 0;
        bool firsttime = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_x1_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = false;
            btn_xCount++;
            MessageDisplay();
        }

        private void btn_x2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            btn_xCount++;
            MessageDisplay();
        }

        private void btn_x3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            btn_xCount++;
            MessageDisplay();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (firsttime)
            {
                this.Text = "Win: 0  Lose: 0";
                firsttime = false;
            }
            btn_xCount = 0;
            timer1.Enabled = timer2.Enabled = timer3.Enabled = true;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (btnFlip.Text == "Flip twice/second")
            {
                timer1.Interval = timer2.Interval = timer3.Interval = 500;
                btnFlip.Text = "Flip once/second";
            }
            else
            {
                timer1.Interval = timer2.Interval = timer3.Interval = 1000;
                btnFlip.Text = "Flip twice/second";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangingPictures(pic1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ChangingPictures(pic2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ChangingPictures(pic3);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageDisplay()
        {
            if (btn_xCount == 3)
            {
               if ((pic1.Tag == pic2.Tag) && (pic2.Tag == pic3.Tag))
                {
                    MessageBox.Show("You win!!!");
                    winCount++;
                }
                else
                {
                    MessageBox.Show("Try again...");
                    lostCount++;
                }

                this.Text = "Win: " + winCount + " Lose: " + lostCount;
                
            }
        }



        private void ChangingPictures(PictureBox c)
        {
            int randNo = r.Next(4);
            switch (randNo)
            {
                case 0:
                    {
                        c.Image = Properties.Resources.Banana;
                        c.Tag = "Banana";
                        break;
                    }
                case 1:
                    {
                        c.Image = Properties.Resources.Cherry;
                        c.Tag = "Cherry";
                        break;
                    }
                case 2:
                    {
                        c.Image = Properties.Resources.Orange;
                        c.Tag = "Orange";
                        break;
                    }
                case 3:
                    {
                        c.Image = Properties.Resources.Watermelon;
                        c.Tag = "Watermelon";
                        break;
                    }
            }

        }
    }
}
