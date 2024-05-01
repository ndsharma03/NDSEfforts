using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMemory;
using Newtonsoft.Json;
using System.IO;
using MyMemory.New;
namespace Tester
{
  public class TestEntities
    {
       


        public static void Main()
        {
            //CreateCategories();
            Category c =(Category)JSONEntities.GetEntityByName("ANGULAR JS",EntityType.Category);
            c.Name = "Angular JS";
            JSONEntities.SaveEntity(new Category());
        }

        public static void CreateCategories()
        {
            //Main Categories

            //Clean file content
            using (StreamWriter writer = new StreamWriter(@"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\" + "Category" + ".Json.txt", false))
            {
                writer.Write(string.Empty);

            }
            Category main1 =  AddCategory("Technology", 0);
          Category underCS =AddCategory("C#", main1.Id);
                            AddCategory("Thereading", underCS.Id);
                            AddCategory("Task-Async-Await", underCS.Id);
                            AddCategory("Exception", underCS.Id);
                            AddCategory("OOPS", underCS.Id);
                            AddCategory("Memory Management", underCS.Id);

                    AddCategory("SQL Server", main1.Id);
                    AddCategory("WCF", main1.Id);
                    AddCategory("WPF", main1.Id);
                    AddCategory("JAVA SCRIPT", main1.Id);
                    AddCategory("WEB API", main1.Id);
                    AddCategory("ANGULAR JS", main1.Id);
                    AddCategory("ASP.NET MVC", main1.Id);
                    AddCategory("ASP.NET MVC CORE", main1.Id);
                    AddCategory("HTML", main1.Id);
                    AddCategory("CSS", main1.Id);

            Category main2 = AddCategory("Domain", 0);


            //Category c =(Category)JSONEntities.GetEntityByName("ANGULAR JS",EntityType.Category);
         
           
            JSONEntities.SaveEntity(new Category());


        }


        public static Category AddCategory(string description, int parent)
        {
            Category c1 = new Category { Name = description, Parent = parent }; //Id=1
            JSONEntities.AddEntity(c1);
            return c1;
        }
    }
}
