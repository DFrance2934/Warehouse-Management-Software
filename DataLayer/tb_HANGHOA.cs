//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_HANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_HANGHOA()
        {
            this.tb_HOADON_CT = new HashSet<tb_HOADON_CT>();
            this.tb_NHAPHANG = new HashSet<tb_NHAPHANG>();
            this.tb_TONKHO = new HashSet<tb_TONKHO>();
        }
    
        public int IDHH { get; set; }
        public string TENHH { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public string MOTA { get; set; }
        public Nullable<bool> DISABLED { get; set; }
        public string DVT { get; set; }
        public string IDNCC { get; set; }
        public Nullable<int> IDNHOM { get; set; }
    
        public virtual tb_NHACUNGCAP tb_NHACUNGCAP { get; set; }
        public virtual tb_NHOMHH tb_NHOMHH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HOADON_CT> tb_HOADON_CT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NHAPHANG> tb_NHAPHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TONKHO> tb_TONKHO { get; set; }
    }
}
