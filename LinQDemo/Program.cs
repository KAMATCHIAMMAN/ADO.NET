using System.Runtime.InteropServices;

namespace LinQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****LINQ INTRO********

            //string[] employeedetails = { "kamatchi", "srimathi", "kavi" };
            //IEnumerable<string> Evenlength = from name in employeedetails
            //                                 where name.Length % 2 == 0
            //                                 select name;
            //foreach(string name in Evenlength)
            //{
            //    Console.WriteLine(name);
            //
            //
            //}

            ///****AGGREGATE FUNCTION**************

            //int[] num = { 2, 3, 4, 5, };
            //int total = num.Aggregate((a, b) => a + b);
            //Console.WriteLine(total);



            //Console.WriteLine(num.Count());
            //Console.WriteLine(num.Min());
            //Console.WriteLine(num.Max());
            //Console.WriteLine(num.Sum());


            var studentlist = from student in Students.StudentDetails()
                              orderby student.rollNumber descending
                              select student;

            //foreach(var student in studentlist)
            //{
            //    Console.WriteLine(student.rollNumber+" "+student.studentName);
            //}



            //var studenrlisttwo = Students.StudentDetails().OrderBy(s => s.gender).ThenBy(n => n.studentName);



            //*****Elementry level functions************


            var studentone = Students.StudentDetails().ElementAt(2);

            Console.WriteLine("student at second place " +studentone.studentName);

            var studenttwo = Students.StudentDetails().ElementAtOrDefault(4);
            Console.WriteLine("student at defult place" + studenttwo.studentName);


            var studentthree = Students.StudentDetails().First();
            Console.WriteLine("First student name" + studentthree.studentName);


            var studentfour = Students.StudentDetails().Last();
            Console.WriteLine("First student name" + studentfour.studentName);

            var studentfive= Students.StudentDetails().LastOrDefault();
            Console.WriteLine(studentfive.studentName);

            var studentsix = Students.StudentDetails().Single();
            Console.WriteLine(studentsix.studentName);

            var studentseven=Students.StudentDetails().SingleOrDefault();


            int[] numbrs = { 1, 3 };
            var elements = numbrs.DefaultIfEmpty();
            foreach(var item in elements)
            {
                Console.WriteLine(item);
            }

        }
    }
}