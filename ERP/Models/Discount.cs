//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discount
    {
        public string CompCode { get; set; }
        public string PdCode { get; set; }
        public Nullable<System.DateTime> PdDate { get; set; }
        public string RegionCode { get; set; }
        public string PartyCode { get; set; }
        public string ItemCode { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public string UpdTerm { get; set; }
        public string UpdUser { get; set; }
    }
}
