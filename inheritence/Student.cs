using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    public class Student : Person
    {
        public string Semester { get; set; }
        public string GPA { get; set; }
        public string Degree { get; set; }

        public void display(Student student)
        {
            Console.WriteLine("Name of the student is " + student.Name + "\nAge of the student is " + student.Age + "\nSemester of the student is " + student.Semester);
        }
    }
}
