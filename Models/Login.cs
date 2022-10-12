using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}