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
    
    public partial class PatientDataAccess
    {
        public int id { get; set; }
        public int PatientId { get; set; }
        public int HospitalId { get; set; }
        public System.DateTime AccessRequestDate { get; set; }
        public bool IsLatest { get; set; }
    
        public virtual Hospital Hospital { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
