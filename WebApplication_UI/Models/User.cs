using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_UI.Models
{
    public class User
    {


        [Required]
        [StringLength(15)]
        [Display(Name = "User name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The email address is required")]
       // [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [StringLength(50, ErrorMessage = "Must be between 10 and 50 characters", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Display(Name = "Confirm Password")]
        [StringLength(50, ErrorMessage = "Must be between 10 and 50 characters", MinimumLength = 10)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


    }
}
