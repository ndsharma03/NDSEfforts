using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace MyMemory.New
{
    public enum EntityType { Notes,Category};
    //*** Jai Shri Ganesh ***
    public interface IEntity
    {
        int Id { get; set; }
        string EntityName { get; }
    }
    public class Notes : IEntity
    {
        public int Id { get; set; }
        public string EntityName { get; private set; } = "Notes";
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int CategotyId { get; set; }
        public string Comments { get; set; }
        public List<string> Attachements { get; set; }
        public int CreatedBy { get; set; }//user id
        public DateTime CreateDate { get; set; }
        public int ModifiedBy { get; set; }//user id
        public DateTime ModifiedDate { get; set; }
    }
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string EntityName { get; private set; } = "Category";
        public string Name { get; set; }
        public int Parent { get; set; }
    }
    //public class SubCategory : IEntity
    //{
    //    public int Id { set; get; }
    //    public string EntityName { get; private set; } = "SubCategory";
    //    public string Description { get; set; }
    //    public int CategoryId { set; get; }
    //}


    


    public static class JSONEntities
    {

        static Dictionary<string, string> regEntities = new Dictionary<string, string>
        {
            {"Notes", @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\" },
            {"Category", @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\" }
            //,
           // {"SubCategory", @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\" }
        };


        private static List<Notes> Notes { get; set; } = new List<Notes>();
        private static List<Category> Categories { get; set; } = new List<Category>();
       // public static List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

        static string JSONDirectoryPath { get; set; } = @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\";

        static List<List<IEntity>> entities = new List<List<IEntity>>();


        static JSONEntities()
        {
            foreach (string key in regEntities.Keys)
            {
                using (StreamReader reader = new StreamReader(JSONDirectoryPath + key + ".Json.txt"))
                {
                    string jsonString = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(jsonString))
                    {
                        switch (key)
                        {
                            case "Notes":
                                Notes = JsonConvert.DeserializeObject<List<Notes>>(jsonString);
                                break;
                            case "Category":
                                Categories = JsonConvert.DeserializeObject<List<Category>>(jsonString);
                                break;
                            //case "SubCategory":
                            //    SubCategories = JsonConvert.DeserializeObject<List<SubCategory>>(jsonString);
                            //    break;

                        }
                    }
                }
            }
        }


        public static void SaveEntity(IEntity entity)
        {

            string json = string.Empty;
            switch (entity.EntityName)
            {
                case "Notes":
                    json = JsonConvert.SerializeObject(Notes, Formatting.Indented);
                    break;
                case "Category":
                    json = JsonConvert.SerializeObject(Categories, Formatting.Indented);
                    break;
                //case "SubCategory":
                //    json = JsonConvert.SerializeObject(SubCategories, Formatting.Indented);
                //    break;

            }
            if (!string.IsNullOrEmpty(json))
            {
             
                using (StreamWriter writer = new StreamWriter(JSONDirectoryPath + entity.EntityName + ".Json.txt", false))
                {
                    writer.Write(json);

                }
            }


        }

        public static IEntity GetEntityById(int id,EntityType eType)
        {

            if (eType == EntityType.Category)
            {
                return Categories.Find(x => x.Id == id);
            }
            else if (eType == EntityType.Notes)
            {
                return Notes.Find(x => x.Id == id);
            }
            return null;
        }
        public static IEntity GetEntityByName(string name, EntityType eType)
        {

            if (eType == EntityType.Category)
            {
                return Categories.Find(x => x.Name == name);
            }
            else if (eType == EntityType.Notes)
            {
                return Notes.Find(x => x.Title == name);
            }
            return null;
        }
        public static void AddEntity(IEntity entity)
        {

            string json = string.Empty;
            int id = 0;
            switch (entity.EntityName)
            {
                case "Notes":

                    id = Notes.Count > 0 ? Notes.Max(x => x.Id) : 0;
                    entity.Id = id + 1;
                    Notes.Add((Notes)entity);
                    break;

                case "Category":

                    id = Categories.Count>0? Categories.Max(x => x.Id) :0;
                    entity.Id = id + 1;
                    Categories.Add((Category)entity);
                    break;

            }



        }
        public static void DeleteEntity(IEntity entity)
        {
            switch (entity.EntityName)
            {
                case "Notes":

                    Notes.RemoveAll(x => x.Id == entity.Id);
                    break;

                case "Category":

                    Categories.RemoveAll(x => x.Id == entity.Id);
                    break;


            }
        }



        public static void UpdateEntity(IEntity entity)
        {

            switch (entity.EntityName)
            {
                case "Notes":

                    var objNotes = Notes.Find(x => x.Id == entity.Id);
                    Notes temp = (Notes)entity;

                    objNotes.Title = temp.Title;
                    objNotes.Description = temp.Description;
                    objNotes.Content = temp.Content;
                    objNotes.CategotyId = temp.CategotyId;
                   // objNotes.SubCategory = temp.SubCategory;
                    objNotes.Comments = temp.Comments;
                    objNotes.Attachements = temp.Attachements;
                    objNotes.CreatedBy = temp.CreatedBy;
                    objNotes.CreateDate = temp.CreateDate;
                    objNotes.ModifiedBy = temp.ModifiedBy;
                    objNotes.ModifiedDate = temp.ModifiedDate;

                    break;

                case "Category":


                    var objCategory = Categories.Find(x => x.Id == entity.Id);
                    Category tempcategory = (Category)entity;
                    objCategory.Name = tempcategory.Name;
                    tempcategory.Parent = tempcategory.Parent;

                    break;


            }



        }
    }
}
