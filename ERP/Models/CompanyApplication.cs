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
    
    public partial class CompanyApplication
    {
        public int ID { get; set; }
        public string CompanyCode { get; set; }
        public string ApplicationCode { get; set; }
        public string CreatedBy { get; set; }
        public string Remarks { get; set; }
        public string ActiveFlag { get; set; }
    }
}
