//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom3_QuanLyResort__HQTCSDL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinCheckInOut
    {
        public short MaDatPhong { get; set; }
        public string TenKH { get; set; }
        public Nullable<System.DateTime> NgayDatPhong { get; set; }
        public Nullable<System.DateTime> NgayTraPhong { get; set; }
        public Nullable<decimal> PhiThuThem { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public short MaNV { get; set; }
        public string Nhân_Viên_thực_hiện { get; set; }
    }
}
