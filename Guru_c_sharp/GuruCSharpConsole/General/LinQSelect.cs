using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    class Employee
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<Employee> employees = new List<Employee>();
        //    Employee emp1 = new Employee { Name = "Deepak", Skills = new List<string> { "C", "C++", "Java" } };
        //    Employee emp2 = new Employee { Name = "Karan", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };
        //    Employee emp3 = new Employee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };
        //    Employee emp4 = new Employee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

        //    employees.Add(emp1);
        //    employees.Add(emp2);
        //    employees.Add(emp3);
        //    employees.Add(emp4);

        //    //--------*******************SELECT ********************************************
        //    IEnumerable<List<string>> names = employees.Select(e => e.Skills);//select will return skills for each employee which is list<string> 
            
        //    foreach (List<string> l in names)
        //    {
        //        foreach (string s in l)
        //        {
        //            Console.WriteLine(s);
        //        }
        //    }
        //        //*********************FIND will return single object while FIND All Returns List<T>**************************


        //    List<Employee> lstEmpl = employees.FindAll(x => x.Name == "Lalit");

        //    Employee temp=employees.Find(c => c.Name == "Deepak");

        //    temp.Name = "Nirnaja";           // this changes will be change actual collection(i.e. employees);
           
        //    Console.WriteLine("************** Names after modification *********************");
            
        //    foreach (Employee ee in employees)
        //    {
                
        //        Console.WriteLine(ee.Name);
        //    }


        //   IEnumerable<Employee> filterredEmployee=  employees.Where(x => x.Skills.Contains("SQL Server"));
          
        //   Console.WriteLine("************Filtered Employees ******************");
           
        //    foreach (Employee ee in filterredEmployee)
        //   {
               
        //       Console.WriteLine(ee.Name);
        //   }

        //    //*************** GROUPING AND CONVERSION TO LIST *******************

        //    Dictionary<string, int> dic = new Dictionary<string, int>();


        //    dic = new Dictionary<string, int> { { "sa", 1 }, { "dd", 3 } };
        //    var s2 = (from obj in employees
        //              group employees by obj.Name into grp
        //              select new { Name = grp.Key, Count = grp.Count() }).ToList();


        //    //foreach (IGrouping<string, List<Employee>> g in s2)
        //    //{
        //    //    dic.Add(g.Key, g.Count());
        //    //}
        //    foreach (var g in s2)
        //    {
        //        dic.Add(g.Name, g.Count);
        //    }

        //    // Another way
        //    var s3 = (from obj in employees
        //              group employees by obj.Name into grp
        //              select new Dictionary<string, int> { { grp.Key, grp.Count() } });

        //    List<string> lstStr = new List<string> { "Red", "Green", "Blue", "Green", "Red", "Black" };

        //    var gresult = (from s in lstStr
        //                   group lstStr by s into grp
        //                   select new { Color=grp.Key,
        //                                ColorCount=grp.Count()
        //                   }).ToList();

        //    Console.Read();
        //}
    }
}
