using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public class RegistrationModel : IdentityUser
    {
        
        [Required(ErrorMessage = "The Username field is required.")]
        public override string UserName { get => base.UserName; set => base.UserName = value; }

        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address.")]
        public override string Email { get => base.Email; set => base.Email = value; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [UIHint("password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The Confirm Password field is required.")]
        [DataType(DataType.Password)]
        [UIHint("password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
