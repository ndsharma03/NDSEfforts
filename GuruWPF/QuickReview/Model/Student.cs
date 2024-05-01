using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReview.Model
{
   public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Student> GetStudents()
        {
            List<Student> lstStudent = new List<Student>() { new Student { Name = "Niranjan", Age = 38 }, new Student { Name = "Raj", Age = 30 } };
            return lstStudent;
        }
    }
}
