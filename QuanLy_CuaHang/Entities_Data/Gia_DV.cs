//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gia_DV
    {
        public int ma_GiaDV { get; set; }
        public Nullable<int> ma_DV { get; set; }
        public Nullable<int> gia_DV1 { get; set; }
        public Nullable<System.DateTime> ngay_DBDV { get; set; }
        public Nullable<System.DateTime> ngay_KTDV { get; set; }
    
        public virtual DichVu DichVu { get; set; }
    }
}
