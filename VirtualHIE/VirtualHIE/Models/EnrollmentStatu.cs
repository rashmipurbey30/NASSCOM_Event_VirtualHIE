//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualHIE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnrollmentStatu
    {
        public EnrollmentStatu()
        {
            this.Hospitals = new HashSet<Hospital>();
        }
    
        public int Id { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Hospital> Hospitals { get; set; }
    }
}
