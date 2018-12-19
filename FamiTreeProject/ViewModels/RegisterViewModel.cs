using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FamiTreeProject.Models;

namespace FamiTreeProject.ViewModels
{
    public class RegisterViewModel
    {
        public long id { get; set; }
        public string Name { get; set; }

        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password must match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
