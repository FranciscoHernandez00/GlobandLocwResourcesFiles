using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobandLocwResourcesFiles.Models
{
    public class JobApplication
    {
        [Required(ErrorMessage = "Please provide your name")]
        [Display(Name = "Job applicant name")]
        public string Name { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Job applicant email")]
        public string Email { get; set; }

        //[Required]
        //[RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        //[CustomDate]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please select your sex")]
        [Display(Name = "Job applicant sex")]
        public string Sex { get; set; }

        [Range(2, 4, ErrorMessage = "{0} must be a number between {1} and {2}")]
        [Display(Name = "Job applicant experience")]
        public int Experience { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the Terms")]
        [Display(Name = "Terms")]
        public bool TermsAccepted { get; set; }
    }
}
