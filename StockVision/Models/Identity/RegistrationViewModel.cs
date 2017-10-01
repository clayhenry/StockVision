using System.ComponentModel.DataAnnotations;

namespace StockVision.Models.Identity
{
    public class RegistrationViewModel
    {
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password did not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }


    }
}