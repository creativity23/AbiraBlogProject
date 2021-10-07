using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbiraBlogProject.ViewModels
{
    public class ContactMe
    {   [Required]
        [StringLength(80, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters long.", MinimumLength = 2)]

        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters long.", MinimumLength = 2)]
        public string Email {get; set;}

        [Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters long.", MinimumLength = 2)]
        public string Subject { get; set; }

        [Required]
        [StringLength(550, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters long.", MinimumLength = 2)]
        public string Message { get; set; }
    

    }
}
