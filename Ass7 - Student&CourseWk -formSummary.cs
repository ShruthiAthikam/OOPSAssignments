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
    public partial class formSummary : Form
    {
        List<Course> coursesList = new List<Course>();
        List<Student> studentsList = new List<Student>();
        Course c;
        Student s;
        public formSummary()
        {
            InitializeComponent();
        }
        public formSummary(List<Course> courseList, List<Student> studentList)
        {
            InitializeComponent();
            this.coursesList = courseList;
            this.studentsList = studentList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formSummary_Load(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();
            foreach (Course c in coursesList)
            {
                lbCourses.Items.Add(c.CourseNum);
            }
            lbStudents.Items.Clear();
            foreach (Student s in studentsList)
            {
                lbStudents.Items.Add(s.StudentID);
            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Course course in coursesList)
                {
                    if (lbCourses.SelectedItem.Equals(course.CourseNum))
                    {
                        c = course;
                        break;
                    }
                }
                MessageBox.Show(c.coursedetails());
            }
            catch
            {
                MessageBox.Show("Select a course from the list");

            }
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Student student in studentsList)
                {
                    if (lbStudents.SelectedItem.Equals(student.StudentID))
                    {
                        s = student;
                        break;
                    }
                }
                MessageBox.Show(s.studentdetails());
            }
            catch
            {
                MessageBox.Show("Select a student from the list");
            }
        }
    }
}
