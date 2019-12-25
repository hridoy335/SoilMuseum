using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoilMuseum.Models
{ 
    [MetadataType(typeof(metadataSoil_Discription))]
    public partial class Soil_Discription
    {
    }
    public class metadataSoil_Discription
    {
        [Required(ErrorMessage = "Insert Makedate")]
        [Display(Name = "MakeDate")]
        public System.DateTime Makedate { get; set; }
        public int Employee_ID { get; set; }
        [Display(Name = "Image Path")]
        [Required(ErrorMessage = "Insert Image")]
        public string Image_Path { get; set; }
        [Display(Name = "Discription")]
        [Required(ErrorMessage = "Insert Discription")]
        public string Discription { get; set; }
    }
}