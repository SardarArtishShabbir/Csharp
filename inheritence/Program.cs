using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    public class Program
    {
        static void Main(string[] args)
        {
           Teacher teacher = new Teacher();

            teacher.Name = "Sir Hammad";
            teacher.Age = 27;
            teacher.pay = "30000";
            teacher.Qualification = "Mphil";
            teacher.Department = "Artificial intelligence";

            teacher.display(teacher);

            Student student = new Student();

            student.Name = "Artish";
            student.Age = 20;
            student.Semester = "4th"; 
            student.display(student);

            Admin admin = new Admin();
            admin.Name = "sardar";
            admin.Age = 30;
            admin.Rank = "17";
            admin.Pay = "5000";
            admin.Mobile = "03449584558";
            admin.display(admin);

            
            
            
            Console.ReadLine();
        }
    }
}
