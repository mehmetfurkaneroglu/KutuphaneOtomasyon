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
    
    public partial class Kategori
    {
        public int Kategori_id { get; set; }
        public string Kategori_ad { get; set; }
    
        public virtual Kitap_Kategori Kitap_Kategori { get; set; }
    }
}
