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
    public partial class formStudent : Form
    {
        Student s;
        bool firsttime = false;
        bool Clearcalled = false;
        bool removeItem = false;
       
        List<Course> coursesList = new List<Course>();
        List<Student> studentsList = new List<Student>();
        formSummary f3;
        public formStudent()
        {
            InitializeComponent();
        }



        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Clearcalled)
            {
                labEnrolledCoursesErrorMsg.Text = "";
                lbEnrolledCourses.Items.Clear();
               /// lbCourseWorkNscores.Items.Clear();
                foreach (Student student in studentsList)
                {
                    if (student.StudentID.Equals(cbStudent.SelectedItem))
                        s = student;
                }
                firsttime = true;
                txtTotalEarnedHours.Text = s.TotalEarnedHours.ToString();
                
                lbStudentCourses.SelectedIndex = -1;
                txtStudentId.Text = s.StudentID;
                

                foreach (Course c1 in s.ListOfCoursesEnrolled)
                {
                    lbEnrolledCourses.Items.Add(c1.CourseNum);
                }
               
                              
                firsttime = false;
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            if (!Clearcalled)
            {
                 if (cbStudent.SelectedIndex == -1)
                {
                    if (txtStudentId.Text == "")
                    {
                        labEnrolledCoursesErrorMsg.Text = "Student ID cannot be left blank";
                        btnStudentSave.Enabled = txtTotalEarnedHours.Enabled = lbStudentCourses.Enabled = lbEnrolledCourses.Enabled = false;
                    }
                    else
                    {
                        s = new Student();
                        if (!CheckifstudentIDexists())
                        {
                            s.StudentID = txtStudentId.Text;
                            labEnrolledCoursesErrorMsg.Text = "";
                            btnStudentSave.Enabled = txtTotalEarnedHours.Enabled = lbStudentCourses.Enabled = lbEnrolledCourses.Enabled = true;

                        }
                        else
                        {
                            labEnrolledCoursesErrorMsg.Text = "Student ID already exists";
                            btnStudentSave.Enabled = txtTotalEarnedHours.Enabled = lbStudentCourses.Enabled = lbEnrolledCourses.Enabled = false;
                        }
                    }


                }
                else
                {
                    if (!firsttime)
                    {
                        if (txtStudentId.Text == "")
                        {
                            labEnrolledCoursesErrorMsg.Text = "Student ID cannot be left blank";
                            btnStudentSave.Enabled = txtTotalEarnedHours.Enabled = lbStudentCourses.Enabled = lbEnrolledCourses.Enabled = false;
                        }
                        else
                        {
                            removeItem = true;
                            if (!CheckifstudentIDexists())
                            {
                                s.StudentID = txtStudentId.Text;
                                labEnrolledCoursesErrorMsg.Text = "";
                                btnStudentSave.Enabled = txtTotalEarnedHours.Enabled = lbStudentCourses.Enabled = lbEnrolledCourses.Enabled = true;
                            }
                            else
                            {
                                labEnrolledCoursesErrorMsg.Text = "Student ID already exists";
                                btnStudentSave.Enabled = false;
                                btnStudentSave.Enabled = txtTotalEarnedHours.Enabled = lbStudentCourses.Enabled = lbEnrolledCourses.Enabled = false;
                            }
                        }
                    }
                }
            }
        }


        private bool CheckifstudentIDexists()
        {
            if (studentsList.Count != 0)
            {
                foreach (Student s1 in studentsList)
                {
                    if(s1.StudentID.ToLower().Trim() ==  txtStudentId.Text.ToLower().Trim())
                        //if (s1.StudentID.Equals(txtStudentId.Text))
                        return true;
                }
                return false;
            }
            else
                return false;
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            coursesList = (List<Course>)this.Tag;
            foreach (Student student in studentsList)
            {
                cbStudent.Items.Add(student.StudentID);
            }
            lbStudentCourses.Items.Clear();
            foreach (Course c2 in coursesList)
            {
                lbStudentCourses.Items.Add(c2.CourseNum);
            }
        }

        private void lbStudentCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (s.StudentID.Equals(txtStudentId.Text))
                {
                    labEnrolledCoursesErrorMsg.Text = "";
                    btnStudentSave.Enabled = true;

                    if (lbStudentCourses.SelectedIndices.Count > 5)
                    {
                        labEnrolledCoursesErrorMsg.Text = "You can enroll only upto 5 courses.";
                        btnStudentSave.Enabled = false;
                    }

                    else
                    {
                        labEnrolledCoursesErrorMsg.Text = "";
                        btnStudentSave.Enabled = true;
                        if (!firsttime && !Clearcalled)
                        {
                            lbEnrolledCourses.Items.Clear();
                            s.ListOfCoursesEnrolled.Clear();
                            lbCourseWk.Items.Clear();
                            foreach (String str in lbStudentCourses.SelectedItems)
                            {
                                lbEnrolledCourses.Items.Add(str);
                                foreach (Course c3 in coursesList)
                                {
                                    if (str.Equals(c3.CourseNum))
                                    {
                                        Course copy = new Course();
                                        copy.CourseName = c3.CourseName;
                                        copy.CourseNum = c3.CourseNum;
                                        foreach (KeyValuePair<string, int> pair in c3.CourseWork)
                                        {
                                            copy.CourseWork.Add(pair.Key, pair.Value);
                                        }

                                        s.ListOfCoursesEnrolled.Add(copy);


                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (lbStudentCourses.SelectedIndex == -1)
                    {
                        labEnrolledCoursesErrorMsg.Text = "";
                        btnStudentSave.Enabled = true;
                    }
                    else
                    {
                        if (!firsttime && !Clearcalled)
                        {
                            labEnrolledCoursesErrorMsg.Text = "Enter Student ID";
                            btnStudentSave.Enabled = false;
                        }
                    }
                }
            }
            catch
            {               
                    labEnrolledCoursesErrorMsg.Text = "Enter Student ID";
                    btnStudentSave.Enabled = false;                
            }
            
        }

        private void lbEnrolledCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "")
            {
                labEnrolledCoursesErrorMsg.Text = "Student ID cannot be left blank";
                btnStudentSave.Enabled = false;
            }
            else
            {
                lbCourseWk.Items.Clear();
                foreach (Course c4 in s.ListOfCoursesEnrolled)
                {
                    if (lbEnrolledCourses.SelectedItem.Equals(c4.CourseNum))
                    {

                        foreach (KeyValuePair<string, int> k in c4.CourseWork)
                        {
                            lbCourseWk.Items.Add(k.Key);
                        }
                        break;
                    }
                }
            }
        }

        private void lbCourseWk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "")
            {
                labEnrolledCoursesErrorMsg.Text = "Student ID cannot be left blank";
                btnStudentSave.Enabled = false;
            }
            else
            {
                labEnrolledCoursesErrorMsg.Text = "";
                btnStudentSave.Enabled = true;
                if (lbCourseWk.SelectedIndex != -1)
                    btnAddScore.Enabled = true;
            }
        }



        private void btnAddScore_Click(object sender, EventArgs e)
        {
            
            if (!Clearcalled && lbCourseWk.Items.Count != 0 && lbCourseWk.SelectedIndex != -1)
            {
                int courseindex = 0;
                string key = "";
                int score;
                int sum = 0;
                int count = 0;
                
                if (tbScores.Text == "")
                {
                    score = -1;
                    labEnrolledCoursesErrorMsg.Text = "";
                    btnStudentSave.Enabled = true;
                }
                else if (Int32.TryParse(tbScores.Text, out score))
                {

                    if (score > 0 && score <= 100)
                    {
                        labEnrolledCoursesErrorMsg.Text = "";
                        btnStudentSave.Enabled = true;
                    }
                    else
                    {
                        labEnrolledCoursesErrorMsg.Text = "Score must be between 0 and 100";
                        btnStudentSave.Enabled = false;
                    }
                }
                else
                {
                    labEnrolledCoursesErrorMsg.Text = "Score must be an integer between 0 and 100";
                    btnStudentSave.Enabled = false;
                }

                if (score == -1  || (score > 0 && score <= 100))
                {
                    foreach (Course c5 in s.ListOfCoursesEnrolled)
                    {
                        if (lbEnrolledCourses.SelectedItem.Equals(c5.CourseNum))
                        {
                            courseindex = s.ListOfCoursesEnrolled.IndexOf(c5);                           
                            foreach (KeyValuePair<string, int> k in c5.CourseWork)
                            {
                                if (lbCourseWk.SelectedItem.Equals(k.Key))
                                {
                                    key = k.Key;
                                    break;
                                }
                                
                            }
                            break; 
                        }
                    }
                    s.ListOfCoursesEnrolled[courseindex].CourseWork[key] = score;
                    foreach(KeyValuePair<string, int> k in s.ListOfCoursesEnrolled[courseindex].CourseWork)
                    {
                        if (k.Value != -1)
                        {
                            sum += k.Value;
                            count++;
                        }
                    }
                    if (count == 0)
                        s.ListOfCoursesEnrolled[courseindex].CourseGrade = "";
                    else
                        s.ListOfCoursesEnrolled[courseindex].CourseGrade = GradingScale((int)(sum / count));
                    //lbCourseWorkNscores.Items.Clear();
                    tbCourseGrade.Text = s.ListOfCoursesEnrolled[courseindex].CourseGrade;
                    tbScores.Text = "";

                }
            }
        }

        private void btnDisplayCourseGrades_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (Course c6 in s.ListOfCoursesEnrolled)
            {
                msg += c6.CourseWKScoresNGrade() + "\n";
            }
            MessageBox.Show(msg);

        }


        private string GradingScale(int gradescore)
        {
            if (gradescore >= 90 && gradescore <= 100)
                return "A";
            else if (gradescore < 90 && gradescore >= 80)
                return "B";
            else if (gradescore < 80 && gradescore >= 70)
                return "C";
            else if (gradescore < 70 && gradescore >= 60)
                return "D";
            else
                return "F";

        }

      

       

      
        private void txtTotalEarnedHours_TextChanged(object sender, EventArgs e)
        {
            if (!Clearcalled && !firsttime)
            {
                try
                {
                    if (txtStudentId.Text == "")
                    {
                        labEnrolledCoursesErrorMsg.Text = "Enter Student ID";
                        btnStudentSave.Enabled = false;
                    }
                    else
                    {
                        int totalearnedhours;
                        if (Int32.TryParse(txtTotalEarnedHours.Text, out totalearnedhours))
                        {
                            s.TotalEarnedHours = totalearnedhours;
                            labEnrolledCoursesErrorMsg.Text = "";
                            btnStudentSave.Enabled = true;
                        }
                        else
                        {
                            if (cbStudent.SelectedIndex != -1 || txtStudentId.Text != "")
                            {
                                labEnrolledCoursesErrorMsg.Text = "Enter a valid integer number.";
                                btnStudentSave.Enabled = false;
                            }

                        }
                    }
                }
                catch
                {
                    labEnrolledCoursesErrorMsg.Text = "Enter Student ID";
                    btnStudentSave.Enabled = false;
                }
                
            }
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            
            if (removeItem)
            {
                cbStudent.Items.RemoveAt(cbStudent.SelectedIndex);
                removeItem = false;
            }
            if (txtStudentId.Text == "")
            {
                labEnrolledCoursesErrorMsg.Text = "Student ID cannot be left blank";
                
            }
            else
            {
                if (txtTotalEarnedHours.Text == "")
                {
                    labEnrolledCoursesErrorMsg.Text = "Total Earned hours can't be left blank";
                }
                else
                {
                    if (!studentsList.Contains(s))
                        studentsList.Add(s);

                    if (!cbStudent.Items.Contains(s.StudentID))
                        cbStudent.Items.Add(s.StudentID);
                    foreach (Course c7 in s.ListOfCoursesEnrolled)
                    {
                        foreach (Course c8 in coursesList)
                        {
                            if (c7.CourseNum.Equals(c8.CourseNum))
                            {
                                if (!c8.listOfStudentsInCourse.Contains(s))
                                    c8.listOfStudentsInCourse.Add(s);
                            }
                        }
                    }
                    labEnrolledCoursesErrorMsg.Text = "";
                    btnStudentClear_Click(sender, e);
                }
            }
        }

        private void btnStudentDel_Click(object sender, EventArgs e)
        {
            if ((s.StudentID.Equals(txtStudentId.Text)))
            {
                foreach (Course c9 in coursesList)
                {
                    if (c9.listOfStudentsInCourse.Contains(s))
                        c9.listOfStudentsInCourse.Remove(s);
                }
                cbStudent.Items.Remove(s.StudentID);
                studentsList.Remove(s);
            }
            btnStudentClear_Click(sender, e);
        }

        private void btnStudentClear_Click(object sender, EventArgs e)
        {
            Clearcalled = true;
            cbStudent.SelectedIndex = -1;
            txtStudentId.Text = "";
            txtTotalEarnedHours.Text = "";
            lbStudentCourses.SelectedIndex = -1;
            lbEnrolledCourses.Items.Clear();
            lbCourseWk.Items.Clear();
            tbScores.Text = "";
            tbCourseGrade.Text = "";
            //lbCourseWorkNscores.Items.Clear();
            btnAddScore.Enabled = false;
            labEnrolledCoursesErrorMsg.Text = "";
            txtStudentId.Enabled = txtTotalEarnedHours.Enabled = lbStudentCourses.Enabled = lbEnrolledCourses.Enabled = true;
            Clearcalled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            f3 = new formSummary(coursesList,studentsList);
            cbStudent.Items.Clear();
            this.Hide();
            f3.ShowDialog();
            
            
        }

       
















        







    }
}
