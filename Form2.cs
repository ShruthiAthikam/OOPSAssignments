using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contest
{
    public partial class Form2 : Form
    {
        List<Student> teams = new List<Student>();
        List<Student> teamA = new List<Student>();
        List<Student> teamB = new List<Student>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            teams = (List<Student>)this.Tag; //cast 'object' into List<Student>
            MakeTeamA();
            //labAvgA.Text = "Average GPA = " + Student.AvgGPA.ToString("0.000");
        }

        private void MakeTeamA()
        {
            lstA.Items.Clear();
            foreach (Student t in teams)
                teamA.Add(t);
            foreach (Student s in teamA)
                lstA.Items.Add(s.Details);
            UpdateAvgGPA();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            //do not use this.Close(); 
            //since it wipes off the Form2 instance 
            //and both teams A and B will be lost when Form2 is opened again
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (lstA.SelectedIndex != -1)
            {
                string stu_detail = (string)lstA.SelectedItem;
                foreach (Student t in teamA)
                {
                    if (stu_detail.Contains(t.ID))
                    {
                        teamB.Add(t);
                        teamA.Remove(t);
                        lstB.Items.Add(t.Details);
                        lstA.Items.Remove(t.Details);
                        // or,
                        //lstA.Items.RemoveAt(lstA.SelectedIndex);
                        break;  // once moved, no need to iterate through the rest students in teamA
                    }
                }
                UpdateAvgGPA();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lstB.SelectedIndex != -1)
            {
                string studentdetail = (String)lstB.SelectedItem;
                foreach (Student s in teamB)
                {
                    if (studentdetail.Contains(s.ID))
                    {
                        teamA.Add(s);
                        teamB.Remove(s);
                        lstA.Items.Add(s.Details);
                        lstB.Items.Remove(s.Details);
                        break;
                    }
                }
                UpdateAvgGPA();
            }
        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            foreach (Student st in teamA)
            {
                teamB.Add(st);               
                lstB.Items.Add(st.Details);
            }
            teamA.Clear();
            lstA.Items.Clear();
            UpdateAvgGPA();
            
        }
        private void UpdateAvgGPA()
        {
            double sum = 0;
            int count = 0;
            foreach (Student t in teamA)
            {
                sum += t.GPA;
                count++;
            }
            labAvgA.Text = "Average GPA = " + (sum / count).ToString("0.000");
            sum = 0;
            count = 0;
            foreach (Student t in teamB)
            {
                sum += t.GPA;
                count++;
            }
            labAvgB.Text = "Average GPA = " + (sum / count).ToString("0.000"); // "NaN" for 0 / 0
        }

       

       
    }
}
