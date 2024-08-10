using System.ComponentModel.DataAnnotations;

namespace FiltersInAspNet
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
