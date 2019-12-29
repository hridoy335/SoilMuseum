using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoilMuseum.Models
{
    [MetadataType(typeof(metadataZila))]
    public partial class Zila
    {
    }
    public class metadataZila
    {
        [Required(ErrorMessage ="Zila Name Required.")]
        [Display(Name ="Zila Name")]
        public string Zila_Name { get; set; }
        [Display(Name = "Division Name")]
        [Required(ErrorMessage ="Select Division Name.")]
        public int Division_ID { get; set; }
    }
}