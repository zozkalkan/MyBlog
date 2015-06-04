using System;
using System.ComponentModel.DataAnnotations;

namespace JusttBlogg.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

 
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
       
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The length must be in 3-15")]
        [Display(Name = "First name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Surname")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The length must be in 3-15")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter your E_mail")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter valid E_mail")]
        [Display(Name = "E_mail Adress")]
        public string E_mail { get; set; }

        [Required(ErrorMessage = "Please enter your Gender")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter your gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        public DateTime Date { get { return DateTime.Now; } }
    }
}