/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace MyMemory
{
    //*** Jai Shri Ganesh ***
    public interface IEntity
    {
        int Id { get; set; }
        string EntityName { get;}
    }
    public class Notes : IEntity
    {
        public int Id { get;  set; }
        public string EntityName { get; private set; } = "Notes";
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int CategotyId { get; set; }
        public int SubCategory { get; set; }
        public string Comments { get; set; }
        public List<string> Attachements { get; set; }
        public int CreatedBy { get; set; }//user id
        public DateTime CreateDate { get; set; }
        public int ModifiedBy { get; set; }//user id
        public DateTime ModifiedDate { get; set; }
    }
    public class Category : IEntity
    {
        public int Id { get;  set; }
        public string EntityName { get; private set; } = "Category";
        public string Description { get; set; }
    }
    public class SubCategory : IEntity
    {
        public int Id {  set; get; }
        public string EntityName { get; private set; } = "SubCategory";
        public string Description { get; set; }
        public int CategoryId { set; get; }
    }


    //public class EntityMaster
    //{

    //    List<EntityDetails> entityDetails;

    //    public List<EntityDetails> GetRegisteredEntities
    //    {
    //        get
    //        {
    //            return entityDetails;
    //        }
    //    }
    //    public string DataDirectoryPath { get; set; } = @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\";


    //    public EntityMaster()
    //    {
    //        try
    //        {
    //            using (StreamReader reader = new StreamReader(DataDirectoryPath + "EntityMaster.Json"))
    //            {
    //                string jsonString = reader.ReadToEnd();
    //                if (!string.IsNullOrEmpty(jsonString))
    //                {
    //                    entityDetails = JsonConvert.DeserializeObject<List<EntityDetails>>(jsonString);
    //                }
    //            }
    //        }
    //        catch (Exception ex) { throw; }
    //    }

    //    public void Register(string entityName, String jsonFilePath)
    //    {
    //        if (entityDetails is null) entityDetails = new List<EntityDetails>();

    //        entityDetails.Add(new EntityDetails { EntityName = entityName, JSONFilePath = jsonFilePath });
    //        string json = JsonConvert.SerializeObject(entityDetails, Formatting.Indented);
    //        using (StreamWriter writer = new StreamWriter(DataDirectoryPath + "EntityMaster.Json", false))
    //        {
    //            writer.Write(json);

    //        }
    //    }

    //    public class EntityDetails
    //    {
    //        public string EntityName { get; set; }
    //        public string JSONFilePath { get; set; }
    //    }
    //}


    public static class JSONEntities
    {

        static Dictionary<string, string> regEntities = new Dictionary<string, string>
        {
            {"Notes", @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\" },
            {"Category", @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\" },
            {"SubCategory", @"C:\Users\nirsharm\source\repos\MyMemory.NotesRepository\MyMemory.NotesRepository\AppData\" }
        };


        public static List<Notes> Notes { get; set; } = new List<Notes>();
        public static List<Category> Categories { get; set; } = new List<Category>();
        public static List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

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
                            case "SubCategory":
                                SubCategories = JsonConvert.DeserializeObject<List<SubCategory>>(jsonString);
                                break;

                        }
                    }
                }
            }
        }
       

        public static void SaveEntity(IEntity entity)
        {

                string json =string.Empty;
                switch (entity.EntityName)
                {
                    case "Notes":
                         json = JsonConvert.SerializeObject(Notes, Formatting.Indented);
                        break;
                    case "Category":
                        json = JsonConvert.SerializeObject(Categories, Formatting.Indented);
                        break;
                    case "SubCategory":
                        json = JsonConvert.SerializeObject(SubCategories, Formatting.Indented);
                        break;

                }
                if (!string.IsNullOrEmpty(json))
                {
                    using (StreamWriter writer = new StreamWriter(JSONDirectoryPath + entity.EntityName + ".Json.txt", false))
                    {
                        writer.Write(json);

                    }
                }
                        

        }

        public static void AddEntity(IEntity entity)
        {

            string json = string.Empty;
            int id = 0;
            switch (entity.EntityName)
            {
                case "Notes":

                    id =Notes.Count>0? Notes.Max(x => x.Id) :0;
                    entity.Id = id + 1;
                    Notes.Add((Notes)entity);
                    break;

                case "Category":

                    id = Categories.Max(x => x.Id);
                    entity.Id = id + 1;
                    Categories.Add((Category)entity);
                    break;

                case "SubCategory":

                    id = SubCategories.Max(x => x.Id);
                    entity.Id = id + 1;
                    SubCategories.Add((SubCategory)entity);
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

                case "SubCategory":

                    SubCategories.RemoveAll(x => x.Id == entity.Id);
                    break;

            }
        }



        public static void UpdateEntity(IEntity entity)
        {

            switch (entity.EntityName)
            {
                case "Notes":

                    var objNotes = Notes.Find(x=>x.Id==entity.Id);
                    Notes temp = (Notes)entity;
                    
                    objNotes.Title = temp.Title;
                    objNotes.Description = temp.Description;
                    objNotes.Content = temp.Content;
                    objNotes.CategotyId = temp.CategotyId;
                    objNotes.SubCategory = temp.SubCategory;
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
                    objCategory.Description= tempcategory.Description;
                   
                    break;

                case "SubCategory":

                    var objSubCategory = SubCategories.Find(x => x.Id == entity.Id);
                    SubCategory tempSubcategory = (SubCategory)entity;
                    objSubCategory.Description = tempSubcategory.Description;
                    break;

            }



        }
    }
}


open comment to see the code (commented on 12/04/2019 ) */