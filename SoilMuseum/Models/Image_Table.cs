//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoilMuseum.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Image_Table()
        {
            this.Soil_Discription = new HashSet<Soil_Discription>();
        }
    
        public int Image_ID { get; set; }
        public string Image_Path { get; set; }
        public System.DateTime Make_date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Soil_Discription> Soil_Discription { get; set; }
    }
}
