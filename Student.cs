using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7
{
   public class Student
    {
        public static int studentsCount = 0;
        public Student()
        {
            studentsCount++;
        }
        public string StudentID { get; set; }
        public int TotalEarnedHours { get; set; }
        public List<Course> ListOfCoursesEnrolled = new List<Course>();
        public string gpa()
        {
            int count = ListOfCoursesEnrolled.Count;
            int sum = 0;
            foreach (Course c in ListOfCoursesEnrolled)
            {
                try
                {
                    if (c.CourseGrade.Equals("A"))
                        sum += 4;
                    else if (c.CourseGrade.Equals("B"))
                        sum += 3;
                    else if (c.CourseGrade.Equals("C"))
                        sum += 2;
                    else if (c.CourseGrade.Equals("D"))
                        sum += 1;
                    else
                        sum += 0;
                }
                catch
                {
                    sum += 0;
                }             
            }
            if (count == 0)
                return "";
           
            return ((sum*(TotalEarnedHours/ (double)ListOfCoursesEnrolled.Count))/(double)TotalEarnedHours).ToString("f2");
        }

        public string studentdetails()
        {
            string output;
            output = "StudentID - " + StudentID + "\n" ;
            foreach (Course c in ListOfCoursesEnrolled)
                output += "Course Number - " + c.CourseNum + " Course Grade -  " + c.CourseGrade + "\n";
            output +=  "Average GPA - " +  gpa();
            return output;
        }

    }
}
