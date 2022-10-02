using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    public class Admin : Person
    {
        public string Pay { get; set; }
        public string Qualification { get; set; }
        public string Rank { get; set; }

        public void display(Admin admin)
        {
            Console.WriteLine("Name of the admin is " + admin.Name + "\nAge of the Admin is " + admin.Age + "\nRank of the admin is " + admin.Rank + "\nMobile number of the admin is " + admin.Mobile);
        }
    }
}
