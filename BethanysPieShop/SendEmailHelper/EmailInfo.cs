using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BethanysPieShop.SendEmailHelper
{
    public class EmailInfo
    {
        [Required(ErrorMessage = "Please enter valid name")]
        [Display(Name = "Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter valid email")]
        [Display(Name = "Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Display(Name = "Message")]
        [StringLength(400)]
        public string Message { get; set; }
    }
}
