//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenkPrintMVC_v0._5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string ShipVia { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public Nullable<System.DateTime> DeleteDateTime { get; set; }
    }
}
