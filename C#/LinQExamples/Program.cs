using System;
using System.Collections.Generic;
using System.Linq;
namespace LinQExamples
{
    class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
    class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DepartmentId { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


            var Departments = new List<Department>
            {
                new Department{ id=1,Name="IT"},
                new Department{id=2,Name="HR"},
                new Department{id=3, Name="Finance"}
            };
            var Employees = new List<Employee>
            {
                new Employee { id = 1, FirstName = "Niranjan", LastName = "Sharma", DepartmentId = 1 },
                new Employee { id = 1, FirstName = "Pallavi", LastName = "Sharma", DepartmentId = 1 },
                new Employee { id = 1, FirstName = "Manisha", LastName = "Sharma", DepartmentId = 2 },
                new Employee { id = 1, FirstName = "Bhawana", LastName = "Sharma", DepartmentId = 3 },
                new Employee { id = 5, FirstName = "Vasu", LastName = "Sharma", DepartmentId = 9 }

            };

            // -------Inner join-----
            var result = (from d in Departments
                          join e in Employees
                          on d.id equals e.DepartmentId // join condition
                          select new
                          {
                              DepartmentName = d.Name,
                              EmployeeName = e.FirstName + " " + e.LastName
                          });

            foreach (var e in result)
                Console.WriteLine(e.DepartmentName + " " + e.EmployeeName);
           

            //--------------Group Join=============

           var e =Employees.GroupBy(x => x.DepartmentId);

            foreach(var ig in e)
            {
                Console.WriteLine(ig.Key);
                foreach(var emp in ig)
                {
                    Console.WriteLine(emp.FirstName + " " + emp.LastName);
                }
            }
            //var resultGrp=from d in Departments
            //              join e in Employees on d.id equals e.DepartmentId into grp
            //              from g in grp
            //              select new
            //              {
            //                  g.id

            //              }
            Console.ReadLine();
        }
    }
}
