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
    
    public partial class Employee
    {
        public Employee()
        {
            this.Soil_Discription = new HashSet<Soil_Discription>();
        }
    
        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string User_type { get; set; }
        public bool User_Active { get; set; }
    
        public virtual ICollection<Soil_Discription> Soil_Discription { get; set; }
    }
}