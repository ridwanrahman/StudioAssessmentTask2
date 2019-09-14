using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssessmentTask2V3.Models.CustomerForm
{
    public class LoginFormModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public String EmailAddress { get; set; }
        [Required]
        [Display(Name ="Password")]
        public String Password { get; set; }
    }
}