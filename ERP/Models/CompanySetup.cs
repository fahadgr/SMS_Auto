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
    
    public partial class CompanySetup
    {
        public string CompCode { get; set; }
        public string CompName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public Nullable<decimal> Length_Level1 { get; set; }
        public Nullable<decimal> Length_Level2 { get; set; }
        public Nullable<decimal> Length_Level3 { get; set; }
        public Nullable<decimal> Length_LevelDetail { get; set; }
        public Nullable<decimal> GI_MaxLevel { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<decimal> PicSize { get; set; }
        public string NTN { get; set; }
        public string SalesTaxRegNo { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public string UpdUser { get; set; }
        public string UpdTerm { get; set; }
    }
}