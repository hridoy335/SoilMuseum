using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoilMuseum.Models
{
    [MetadataType(typeof(metadataUpozila))]
    public partial class Upozila
    {
    }

    public class metadataUpozila
    {
        [Required(ErrorMessage = "Insert Upozila Name")]
        [Display(Name = "Upozila Name")]
        public string Upozila_Name { get; set; }
    }
}