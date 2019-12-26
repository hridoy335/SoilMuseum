using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoilMuseum.Models
{
    [MetadataType(typeof(metadataEmployee))]
    public partial class Employee
    {
    }
    public class metadataEmployee
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Insert Name.")]
        [MaxLength(20, ErrorMessage = "Name can't be more than 20 characters")]
        public string Employee_Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Insert Email.")]
        [DataType(DataType.EmailAddress)]
        public string Employee_Email { get; set; }

        [Display(Name = "Username")]
        [MaxLength(20, ErrorMessage = "Username can't be more than 20 characters")]
        [Required(ErrorMessage = "Insert Username.")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [MaxLength(20, ErrorMessage = "Password can't be more than 20 characters")]
        [Required(ErrorMessage = "Insert Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "User Type")]
        [Required(ErrorMessage = "Insert Active User.")]
        public string User_type { get; set; }

        [Display(Name = "Active User")]
        [Required(ErrorMessage = "Insert Name.")]
        public bool User_Active { get; set; }
    }
}