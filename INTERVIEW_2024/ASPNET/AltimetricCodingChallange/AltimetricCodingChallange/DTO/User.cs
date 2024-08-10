using System.ComponentModel.DataAnnotations;

namespace AltimerticCodeChallenge.DTO
{
    public class User
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        //public string Email { get; set; }

    }
}
