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
    
    public partial class tblTaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int MaQuyen { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> MaKH { get; set; }
    
        public virtual tblNhanVien tblNhanVien { get; set; }
        public virtual tblQuyen tblQuyen { get; set; }
        public virtual tblKhachHang tblKhachHang { get; set; }
    }
}
