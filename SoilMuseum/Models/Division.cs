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
    
    public partial class Division
    {
        public Division()
        {
            this.Zilas = new HashSet<Zila>();
        }
    
        public int Division_ID { get; set; }
        public string Division_Name { get; set; }
    
        public virtual ICollection<Zila> Zilas { get; set; }
    }
}
