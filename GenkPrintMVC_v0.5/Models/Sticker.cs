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
    
    public partial class Sticker
    {
        public int StikerId { get; set; }
        public Nullable<int> material_id { get; set; }
        public Nullable<int> shape_id { get; set; }
        public Nullable<int> printing_id { get; set; }
        public Nullable<int> cutmethod_Id { get; set; }
        public Nullable<int> lamination_id { get; set; }
        public Nullable<int> delivery_Id { get; set; }
        public Nullable<int> priority_Id { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDatetime { get; set; }
        public string DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteDatetime { get; set; }
        public Nullable<decimal> width { get; set; }
        public Nullable<decimal> hight { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual CutMethod CutMethod { get; set; }
        public virtual DeliveryMethod DeliveryMethod { get; set; }
        public virtual LaminationMethod LaminationMethod { get; set; }
        public virtual Material Material { get; set; }
        public virtual PrintingMode PrintingMode { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Shape Shape { get; set; }
    }
}