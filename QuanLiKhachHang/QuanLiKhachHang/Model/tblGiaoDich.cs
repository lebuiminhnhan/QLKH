//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiKhachHang.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblGiaoDich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGiaoDich()
        {
            this.tblCoUuDai = new HashSet<tblCoUuDai>();
            this.tblLichSuGiaoDich = new HashSet<tblLichSuGiaoDich>();
            this.tblSanPhamGiaoDich = new HashSet<tblSanPhamGiaoDich>();
        }
    
        public int MaGD { get; set; }
        public System.DateTime NgayGiaoDich { get; set; }
        public int TienThanhToan { get; set; }
        public int DiemTich { get; set; }
        public int TienGiam { get; set; }
        public int DiemTru { get; set; }
        public int TrangThai { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCoUuDai> tblCoUuDai { get; set; }
        public virtual tblKhachHang tblKhachHang { get; set; }
        public virtual tblNhanVien tblNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLichSuGiaoDich> tblLichSuGiaoDich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSanPhamGiaoDich> tblSanPhamGiaoDich { get; set; }
    }
}
