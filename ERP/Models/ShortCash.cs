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
    
    public partial class ShortCash
    {
        public string CSCode { get; set; }
        public Nullable<System.DateTime> CSDate { get; set; }
        public string RegionCode { get; set; }
        public string EmpCode { get; set; }
        public Nullable<double> CashSubmited { get; set; }
        public Nullable<double> cheqPaidBack { get; set; }
        public Nullable<double> CashPaidBack { get; set; }
        public Nullable<double> BouncedCheque { get; set; }
        public Nullable<double> Adjustment { get; set; }
        public string UpdUser { get; set; }
        public string UpdTerm { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
    }
}
