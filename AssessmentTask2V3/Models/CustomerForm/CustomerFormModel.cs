using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssessmentTask2V3.Models.CustomerForm
{
    public class CustomerFormModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public String FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public String EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String Password { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public String PhoneNumber { get; set; }
        public String isActive { get; set; }
    }
}