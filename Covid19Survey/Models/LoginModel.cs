using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Survey.Models
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [UIHint("passwprd")]
        public String Password { get; set; }
        public string ReturnUrl { get; set; } = "/";

    }
}
