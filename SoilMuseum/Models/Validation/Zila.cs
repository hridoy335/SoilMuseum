using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoilMuseum.Models
{
    [MetadataType(typeof(metadataAccrss_Mathod))]
    public partial class Accrss_Mathod
    {
    }

    public class metadataAccrss_Mathod
    {
        [Required(ErrorMessage = "Insert Method Name")]
        [Display(Name = "Mathod Name")]
        public string Mathod_Name { get; set; }
        [Required(ErrorMessage = "Insert Ip Address")]
        [Display(Name = "IP Address")]
        public string IP_Address { get; set; }
        [Required(ErrorMessage = "Insert Makedate")]
        [Display(Name = "MakeDate")]
        public System.DateTime Makedate { get; set; }
        [Required(ErrorMessage = "Insert Time")]
        [Display(Name = "Time")]
        public System.TimeSpan Time { get; set; }
    }
}