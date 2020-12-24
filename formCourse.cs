using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass7
{
    public partial class formCourse : Form
    {
        formStudent f2 = new formStudent();
        List<Course> CoursesList = new List<Course>();
        Course c;

        public formCourse()
        {
            InitializeComponent();
        }

        private void btnCourseExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCourseNextForm_Click(object sender, EventArgs e)
        {
           
            f2.Tag = CoursesList;
            f2.ShowDialog();
        }

        private void btnCourseClear_Click(object sender, EventArgs e)
        {
            txtCourseName.Clear();
            txtCourseNumber.Clear();
            txtCourseWk.Clear();
            lbCourseWk.Items.Clear();
            
        }

        private void txtCourseNumber_TextChanged(object sender, EventArgs e)
        {
            foreach (Course course in CoursesList)
            {
                if (course.CourseNum.Equals(txtCourseNumber.Text))
                {                  
                    btnCourseEnter.Enabled = false;
                    labCourseNumErrorMsg.Text = "Course Number already exists.";
                    break;
                }
                else
                {
                    btnCourseEnter.Enabled = true;
                    labCourseNumErrorMsg.Text = "";
                }
            }
        }

       

        private void btnCourseEnter_Click(object sender, EventArgs e)
        {
            c = new Course();
            if (txtCourseName.Text == "" || txtCourseNumber.Text == "")
            {
                labCourseNumErrorMsg.Text = "All fields must be entered.";
            }
            else
            {
                labCourseNumErrorMsg.Text = "";

              
                c.CourseName = txtCourseName.Text;
                c.CourseNum = txtCourseNumber.Text;
                foreach (String s in lbCourseWk.Items)
                {
                    c.CourseWork.Add(s, -1);
                }
                

                CoursesList.Add(c);
                MessageBox.Show("Course " + txtCourseNumber.Text +  " has been saved successfully.");
                btnCourseClear_Click(sender, e);
            }


        }

        private void btnAddCourseWk_Click(object sender, EventArgs e)
        {
           
            bool add = true;
            if (txtCourseWk.Text != "")
            {
                foreach (String s in lbCourseWk.Items)
                {
                    if (s.ToLower().Equals(txtCourseWk.Text.ToLower()))
                    {
                        btnCourseEnter.Enabled = false;
                        labCourseNumErrorMsg.Text = "Course Work already exists for this course.";
                        add = false;
                        break;
                    }                                                              
                }
                if (add)
                {                    
                    lbCourseWk.Items.Add(txtCourseWk.Text);
                    txtCourseWk.Text = "";
                    labCourseNumErrorMsg.Text = "";
                    btnCourseEnter.Enabled = true;
                }                                                               
            }
            else
            {
                labCourseNumErrorMsg.Text = "";
                btnCourseEnter.Enabled = true;
            }
           

        }
    }
}
