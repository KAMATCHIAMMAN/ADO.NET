using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemo
{
    public class Students
    {
        public string rollNumber { get; set; }
        public string studentName { get; set; }
        public string department { get; set; }
        public string gender { get; set; }
        public static List<Students> StudentDetails()
        {
            List<Students> students = new List<Students> 
            { 
            new Students{rollNumber="19cse001",studentName="anuj",department="cse",gender="male"},
            new Students{rollNumber="19cse003",studentName="balamurugan",department="cse",gender="male"},
            new Students{rollNumber="19cse002",studentName="arun",department="ece",gender="male"},
            new Students{rollNumber="19cse004",studentName="deevija",department="ece",gender="female"},
            new Students{rollNumber="19cse005",studentName="kamatchi",department="civil",gender="female"},
            new Students{rollNumber="19cse006",studentName="dharani",department="cse",gender="female"},
            };
            return students;
        }
    }
}
