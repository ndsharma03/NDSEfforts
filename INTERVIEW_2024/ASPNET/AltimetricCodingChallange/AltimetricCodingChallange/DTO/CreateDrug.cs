using System.ComponentModel.DataAnnotations;

namespace AltimerticCodeChallenge.DTO
{
    public class DrugDTO
    {

        [Required]
        [MaxLength(100, ErrorMessage = "{0} can have a maximum of {1} characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "{0} can have a maximum of {1} characters")]
        public string DrugCode { get; set; }
        [Required]
        public bool? IsQualified { get; set; }
        [Required]
        public DateTime ManufactureDate { get; set; }
    }
}
