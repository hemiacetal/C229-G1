using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Username { get; set; }
        
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        [Required]
        [UIHint("password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; } = "/";

    }
}
