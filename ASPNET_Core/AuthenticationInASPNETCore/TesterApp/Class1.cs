using System;
using Model;
namespace TesterApp
{
    public class Class1
    {
        public static void Main()
        {
            using (ApplicationDataContext context = new ApplicationDataContext())
            {
                context.Database.EnsureCreated();
               
             var ee=   context.Employees;
            }
        }
    }
}
