using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    public class Teacher : Person
    {
        public string pay { get; set; }
        public string Department { get; set; }
        public string Qualification { get; set; }

        public void display(Teacher teacher)
        {
            Console.WriteLine("Name of the teacher " + teacher.Name+"\nDepartment of the teacher "+teacher.Department+"\nPay of the teacher is "+teacher.pay);
        }
    
    }
}
