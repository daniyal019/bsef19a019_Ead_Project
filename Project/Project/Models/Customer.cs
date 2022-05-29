using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
    public class Customer
    {

        public int id { get; set; }
        [Required(ErrorMessage = "Enter your Username")]

        public string username { get; set; }
        [Required(ErrorMessage = "Enter your Full Name")]
        [StringLength(20)]
        public string fullName { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Invalid Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Enter your Password")]
        public string password { get; set; }
        [Required(ErrorMessage = "Enter your Name")]
       [StringLength(20)]
        public string contactName { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress]
        public string contactEmail { get; set; }
        [Required(ErrorMessage = "Enter your Feedback")]
        [StringLength(1000)]
        public string feedback { get; set; }

        [Required(ErrorMessage = "Start date and time cannot be empty")]
        //validate:Must be greater than current date
        [DataType(DataType.DateTime)]
        public DateTime date{ get; set; }
        
        [Required(ErrorMessage = "Enter your First Name")]
        [StringLength(10)]
        public string orderfname { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string orderemail { get; set; }
        
        [Required(ErrorMessage = "Enter your Last Name")]
        [StringLength(10)]
        public string orderlname { get; set; }

    }
}
