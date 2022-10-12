using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class ChangePassword
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [DisplayName("New Password")]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        [DisplayName("Confirm New Password")]
        public string ConfirmNewPassword { get; set; }
    }
}