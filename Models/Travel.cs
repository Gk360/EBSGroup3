//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeTravel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Travel
    {
        public int TravelID { get; set; }
        public Nullable<System.DateTime> TravelStartdate { get; set; }
        public Nullable<System.DateTime> TravelEnddate { get; set; }
        public string TravelSource { get; set; }
        public string TravelDestination { get; set; }
    }
}
