using System.ComponentModel.DataAnnotations;

namespace ScavengersRUs.Models.Users
{
    public class CreateAccount
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Ussername { get; set; }  
        [Required]
        public string Password { get; set; }

    }
}
