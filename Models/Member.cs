using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }

    }
}