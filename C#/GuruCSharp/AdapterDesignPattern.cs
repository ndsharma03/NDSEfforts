using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using System.Text.Json.Serialization;

namespace Interview2019
{

    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public Employee()
        {

        }
        public Employee(int eid, string eName)
        {
            EmpID = eid;
            EmpName = eName;
        }
    }

    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>
            {
                new Employee(1,"niranjan"),

                new Employee(2,"Ajay"),
            new Employee(3,"Rajesh")

            };
        }

        public virtual string GetEmployees()
        {
            //System.Runtime.Serialization.XmlObjectSerializer seri= new System.Runtime.Serialization.XmlObjectSerializer();
            var serializer = new XmlSerializer(employees.GetType());
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            serializer.Serialize(sw, employees);
            var str = sb.ToString();
            return str;
        }
    }


    //ADapter implementation.
    // We already have functionality to get employee string in xml format
    // Now we want string of employees in JSON format.

    public interface IEmployee
    {
        string GetEmployees();
    }

    public class EmployeeAdapter:EmployeeManager,IEmployee
    {
        public override string GetEmployees()
        {
            string xmlStr=base.GetEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlStr);
            // return JsonConverter.SerializeObject(doc,NewtonSoft.Json.Formatting.Indented);

            return " JSON String of Emplyees";
        }
    }
    class AdapterDesignPatternTest
    {
        //public static void Main()
        //{
        //    IEmployee emp = new EmployeeAdapter();
        //    emp.GetEmployees(); // you will get JSON Employees.
        //    Console.ReadLine();
        //}
    }
}
