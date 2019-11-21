using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    public class ContactInfo
    {
        [Display(Name = "First Name")]
        public string user_First_Name { get; set; }

        [Display(Name = "Last Name")]
        public string user_Last_Name { get; set; }

        [Display(Name = "Email Address")]
        public string user_Email { get; set; }

        [Display(Name = "Subject")]
        public string user_Subject { get; set; }

        [Display(Name = "Message Body")]
        public string body_Message { get; set; }
    }
}