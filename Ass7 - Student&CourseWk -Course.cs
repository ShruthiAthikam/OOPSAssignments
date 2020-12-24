using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7
{
    public class Course
    {

        public List<Student> listOfStudentsInCourse = new List<Student>();

        public string CourseName { get; set; }

        public string CourseNum { get; set; }

        public SortedList<string, int> CourseWork = new SortedList<string, int>();

        public string CourseGrade { get; set; }

        
       public string coursedetails()
        {
            String output = "Course Name - " + CourseName + " \n" + "Course Number - " + CourseNum + "\n" + "Course Work - " ;
            foreach (KeyValuePair<string, int> coursework in CourseWork)
                output += coursework.Key + " , ";
            output += "\n" + "Number of Students enrolled in the course - " + listOfStudentsInCourse.Count;
            
            return output;
        }
        

           

        public string CourseWKScoresNGrade()
        {
            string msg = "";
            msg =  "Course Number - " + CourseNum + "  "  +  " Course Grade - " + CourseGrade + "\n" + "Course Works: " + "\n" ;
            foreach (KeyValuePair<string, int> k in CourseWork)
            {
                string x = (k.Value == -1) ? "" : k.Value.ToString();               
                msg += k.Key + "   " + "Score - " + x +  "\n";
            }
            return msg;
        }
    }
}
