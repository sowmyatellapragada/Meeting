using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models
{
    public class Response
    {
        [Required(ErrorMessage = "Please enter your name"), MinLength(4),MaxLength(10)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address"),MinLength(6),MaxLength(25)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number"),MinLength(10),MaxLength(10)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
