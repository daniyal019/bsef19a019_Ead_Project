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
    }
}
