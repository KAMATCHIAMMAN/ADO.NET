using Entitycoreframework;
using Entitycoreframework.data;
using Entitycoreframework.module;

namespace Entitycoreframework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using schooldBContext context = new schooldBContext();

            ///insertion 
            //staff staffdetails = new staff()
            //{
            //    staffname = "kamatchi",
            //    salary=25000
            //};
            //context.Add(staffdetails);
            //context.SaveChanges();

            //staff staffdetailstwo = new staff()
            //{
            //    staffname = "srimathi",
            //    salary = 35000
            //};
            //context.Add(staffdetailstwo);
            //context.SaveChanges();

            ///update


           // var updatesalary = context.staff.Where(a => a.staffname == "srimathi").First();
            //if(updatesalary is staff)
            //{
              //  updatesalary.salary = 50000;
            //}

            //context.SaveChanges();


            ////deletion
            ///

            //var deletesalary = context.staff.Where(a => a.Id == 2).First();
            //{
            //    if(deletesalary is staff)
            //    {
            //        context.Remove(deletesalary);
            //    }
            //}
            //context.SaveChanges();


            ///all details
            ///

            var staffdetails=context.staff.Where(a=>a.Id>0).OrderBy(b=>b.staffname);
            foreach(staff details in staffdetails)
            {
                Console.WriteLine(details.staffname + " " + " " + details.salary);
            }
        }
    }
}