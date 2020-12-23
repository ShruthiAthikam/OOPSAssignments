using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass4_vs
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int firstInput ;
        int secInput ;
        int firstRandNo;
        int secRandNo;
        int AboveUpperLimit ;
        int BetweenLimits ;
        int BelowLowerLimit ;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            firstInput = Int32.Parse(txtInt1.Text);
            secInput = Int32.Parse(txtInt2.Text);
            labRand1.Text = r.Next(firstInput, secInput + 1).ToString();
            labRand2.Text = r.Next(firstInput, secInput + 1).ToString();
            firstRandNo = Int32.Parse(labRand1.Text);
            secRandNo = Int32.Parse(labRand2.Text);
            if (txtInt1.Enabled)
                txtInt1.Enabled = false;
            if (txtInt2.Enabled)
                txtInt2.Enabled = false;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            labResult.Text = (firstRandNo + secRandNo).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            labResult.Text = (firstRandNo - secRandNo).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            labResult.Text = (firstRandNo * secRandNo).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            labResult.Text = secRandNo == 0 ? "Cannot divide by zero!" : ((float)firstRandNo / secRandNo).ToString("0.##");           
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            labResult.Text = secRandNo == 0 ? "Cannot divide by zero!" : (firstRandNo % secRandNo).ToString();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            labResult.Text = ((firstRandNo + secRandNo)/(float)2).ToString();
        }

        private void labResult_TextChanged(object sender, EventArgs e)
        {           
            if (labResult.Text != "Cannot divide by zero!")
            {
                int result = (int)(double.Parse(labResult.Text));
                if (result < firstInput)
                {
                    BelowLowerLimit++;
                    labBelow.Text = "Below " + firstInput + " : " + BelowLowerLimit;
                }
                else if (result <= secInput && result >= firstInput)
                {
                    BetweenLimits++;
                    labBetween.Text = "Between " + firstInput + " and " + secInput + " : " + BetweenLimits;
                }
                else
                {
                    AboveUpperLimit++;
                    labAbove.Text = "Above " + secInput + " : " + AboveUpperLimit;
                }
            }            
        }        
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
