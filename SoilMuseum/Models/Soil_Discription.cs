//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoilMuseum.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Soil_Discription
    {
        public int Soil_Discription_ID { get; set; }
        public System.DateTime Makedate { get; set; }
        public int Employee_ID { get; set; }
        public string Image_Path { get; set; }
        public string Discription { get; set; }
        public int Upozila_ID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Upozila Upozila { get; set; }
    }
}
