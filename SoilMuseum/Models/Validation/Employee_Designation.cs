using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoilMuseum.Models
{
    [MetadataType(typeof(metadataEmployee_Designation))]
    public partial class Employee_Designation
    {
    }

   public class metadataEmployee_Designation
    {
        [Display(Name = "Designation Name")]
        [Required(ErrorMessage ="Insert Designation Name.")]
        [MaxLength(20, ErrorMessage = "User name can't be more than 20 characters")]
        public string Designation_Name { get; set; }
    }
}