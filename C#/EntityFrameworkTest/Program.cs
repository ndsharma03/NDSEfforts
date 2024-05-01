using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            foreach (int i in lst.ToList())
            {
                if (i== 5)
                {
                    lst.Remove(i);
                }
            }

            for (int i =0;i<lst.Count;i++)
            {
                if (lst[i] == 5)
                {
                    lst.Remove(lst[i]);
                }
            }

            //AdventureWorks2017Entities entity = new AdventureWorks2017Entities();
            //var emps = entity.Employees;


           

            //ObjectParameter outparam = new ObjectParameter("empCount", typeof(int)); //Calling prodcedure
            //int result=  entity.GetEmployeeById(2, outparam);
            //entity.Database.Log = (string s) => { Console.Write(s); };
            //foreach (Employee e in emps)
            //{
            //    Console.WriteLine(e.BusinessEntityID + "--" + e.BirthDate + "--" + e.JobTitle);
            //}
            //var result2 = entity.Employees.SqlQuery("exec GetEmployeeById2 4").ToList<Employee>();//Executing procedure
            //var result3 = entity.Employees.SqlQuery("select top(5) * from [HumanResources].[Employee]").ToList<Employee>(); //executing SQL Query.
            Console.Read();
            
        }
    }
}

