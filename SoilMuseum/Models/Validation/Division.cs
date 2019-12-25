using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoilMuseum.Models
{
    [MetadataType(typeof(MetadataDivision))]
    public partial class Division
    {
    }

    public class MetadataDivision
    {
        [Required(ErrorMessage = "Insert Division Name")]
        [Display(Name = "Division Name")]
        public string Division_Name { get; set; }
    }
}