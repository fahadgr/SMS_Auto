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
    
    public partial class Sp_PartyAnalysis_Result
    {
        public string RegionCode { get; set; }
        public string PartyCode { get; set; }
        public string PartyName { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public Nullable<int> NoofInvoices { get; set; }
        public double SaleAmount { get; set; }
        public Nullable<System.DateTime> LastSaleDate { get; set; }
    }
}