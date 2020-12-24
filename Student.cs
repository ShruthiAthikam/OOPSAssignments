using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest
{
    class Student
    {
        static int count = 0;
        static double sumGPA = 0;

        public Student()
        {
            count++;
        }

        public static double AvgGPA
        {
            get { return sumGPA / count; }
        }
        double gpa;
        public string ID { get; set; }
        public string Name { get; set; }
        public double GPA 
        {
            get { return gpa; }
            set {
                if (value >= 0 && gpa <= 4)
                {
                    gpa = value;
                    sumGPA += gpa;
                }
                else
                    gpa = 0;
            }
        }
        public string College { get; set; }
        public string Major { get; set; }
        public string Details
        {
            get
            {
                return ID + " (" + Name + ", " + GPA + ", "
                    + College + ", " + Major + ")";
            }
        }
    }
}
