//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public string TasnifNo { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public Nullable<bool> KiralikDurumu { get; set; }
        public int YazarId { get; set; }
        public int KategoriId { get; set; }
        public int YayinEviId { get; set; }
        public int KullaniciId { get; set; }
        public Nullable<System.DateTime> KiralanmaTarihi { get; set; }
        public Nullable<System.DateTime> İadeTarihi { get; set; }
    
        public virtual Yazar Yazar { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual YayinEvi YayinEvi { get; set; }
        public virtual OkunanKitap OkunanKitap { get; set; }
    }
}
