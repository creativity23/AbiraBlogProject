﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AbiraBlogProject.Models
{
    public class BlogUser: IdentityUser
    {
        [Required]
        [StringLength(60, ErrorMessage = "The {0} must be at least {2} and no more than {1} character long", MinimumLength = 1)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "The {0} must be at least {2} and no more than {1} character long", MinimumLength = 1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(70, ErrorMessage = "The {0} must be at least {2} and no more than {1} character long", MinimumLength = 1)]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        public byte[] Image { get; set; }
        public string ContentType { get; set; }

        [StringLength(175, ErrorMessage = "The {0} must be at least {2} and no more than {1} character long", MinimumLength = 1)]
        public string GithubUrl { get; set; }

        [StringLength(175, ErrorMessage = "The {0} must be at least {2} and no more than {1} character long", MinimumLength = 1)]
        public string TwitterUrl { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();

    }
}











//[StringLength(55, ErrorMessage = "The {0} must be at least {2} and no more than {1} character long", MinimumLength = 1)]
//[Display(Name = "Last Name")]
