using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AltimerticCodeChallenge.Entities
{
    public class Drug
    {
        public int Id { get; set; } // by convention EF Core will make this field Primary key

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string DrugCode { get; set; } 
        public bool? IsQualified { get; set; }
        public DateTime ManufactureDate { get; set; }
    }
}

