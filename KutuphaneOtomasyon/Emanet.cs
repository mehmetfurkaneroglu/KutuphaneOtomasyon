//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emanet
    {
        public int Uye_id { get; set; }
        public Nullable<int> Kitap_id { get; set; }
        public Nullable<System.DateTime> Alis_tarihi { get; set; }
        public Nullable<System.DateTime> Teslim_tarihi { get; set; }
    
        public virtual Kitap Kitap { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
