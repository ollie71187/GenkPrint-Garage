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
    
    public partial class CutMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CutMethod()
        {
            this.Stickers = new HashSet<Sticker>();
        }
    
        public int cutmethod_Id { get; set; }
        public string cutmethod_code { get; set; }
        public string cutmethod_name { get; set; }
        public string cutmethod_desc { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string Createby { get; set; }
        public Nullable<System.DateTime> CreateDatetime { get; set; }
        public string Deleteby { get; set; }
        public Nullable<System.DateTime> DeleteDatetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sticker> Stickers { get; set; }
    }
}
