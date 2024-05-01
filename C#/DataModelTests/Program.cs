using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace DataModelTests
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
            QuickRevisionEntities context = new QuickRevisionEntities();

            //var Departments = new List<Department>
            //{
            //    new Department{ id=1,Name="IT"},
            //    new Department{id=2,Name="HR"},
            //    new Department{id=3, Name="Finance"}
            //};
            //var Employees=new List<Employee>
            //{
            //    new Employee{ id=1, FirstName="Niranjan", LastName="Sharma", DepartmentId=1},
            //    new Employee{ id=1, FirstName="Pallavi", LastName="Sharma", DepartmentId=1},
            //    new Employee{ id=1, FirstName="Manisha", LastName="Sharma", DepartmentId=2},
            //    new Employee{ id=1, FirstName="Bhawana", LastName="Sharma", DepartmentId=3},
            //    new Employee{ id=5, FirstName="Vasu", LastName="Sharma",DepartmentId=9}

            //}


            //var result = (from d in context.Departments
            //             join e in context.Employees
            //             on d.DepartmentId equals e.DepartmentId
            //             select new
            //             {
            //                 DepartmentName = d.DepartmentName,
            //                 EmployeeName = e.FirstName + " " + e.LastName
            //             });

            //foreach (var e in result)
            //    Console.WriteLine(e.DepartmentName + " " + e.EmployeeName);

            //var t = from d in context.Departments //This query will produce cross join  
            //        from e in context.Employees
            //        orderby  e.FirstName
            //        select new
            //        {
            //            empname = e.FirstName + " " + e.LastName,
            //            deptname = d.DepartmentName
            //        };

            //     foreach( var v in t)
            //{
            //    Console.WriteLine(v.empname + "............" + v.deptname);


            //}

            //Console.WriteLine("No. Of Records in department ::"+context.Departments.Count());
            //Console.WriteLine("No. Of Records in Employee ::" + context.Employees.Count());
            //Console.WriteLine("No. Of Records in Query result ::" + t.Count());

            // Left join

            var empl = from emp in context.Employees
                       join dept in context.Departments on emp.DepartmentId equals dept.DepartmentId into enp_dept
                         where emp.DepartmentId == 1
                       from d in enp_dept.DefaultIfEmpty()
                       select new
                       {
                           em = emp.FirstName + " " + emp.LastName,
                           depr = d.DepartmentName
                       };

            foreach (var e in empl)
            {
                Console.WriteLine(e.em + " " + e.depr);
            }


            // Grouping
            var empl1 = from emp in context.Employees
                       join dept in context.Departments on emp.DepartmentId equals dept.DepartmentId into enp_dept
                       //  where emp.DepartmentId == 2
                       from d in enp_dept.DefaultIfEmpty()
                       group emp by emp.DepartmentId into emp_grp
                       select new
                       {
                           grpKey = emp_grp.Key,
                           val = emp_grp.OrderBy(x=>x.FirstName)


                       };
                         

            foreach (var key in empl1)
            {
                Console.WriteLine(key);

                foreach (var e in key.val)
                {
                    Console.WriteLine(e.FirstName + " " + e.LastName);
                }
            }

            Console.Read();

        }
    }
}
