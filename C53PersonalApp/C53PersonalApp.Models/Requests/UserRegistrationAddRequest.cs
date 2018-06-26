using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C53PersonalApp.Models.Requests
{
    public class UserRegistrationAddRequest
    {
        [Required, MinLength(2), MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(128), MinLength(3)]
        public string Email { get; set; }
        [Required, MinLength(2), MaxLength(30)]
        public string UserName { get; set; }
        [Required, MinLength(8), MaxLength(50)]
        public string Password { get; set; }
    }
}
