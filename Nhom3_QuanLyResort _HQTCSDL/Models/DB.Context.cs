﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLResortEntities : DbContext
    {
        public QLResortEntities()
            : base("name=QLResortEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CheckInOut> CheckInOuts { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DatDichVu> DatDichVus { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<DatTienIchResort> DatTienIchResorts { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DonGiaPhong> DonGiaPhongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<PhieuXacNhanDatPhong> PhieuXacNhanDatPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TienIchResort> TienIchResorts { get; set; }
        public virtual DbSet<ThongKeDoanhThu> ThongKeDoanhThus { get; set; }
        public virtual DbSet<DanhSachTaiKhoanKhachHang> DanhSachTaiKhoanKhachHangs { get; set; }
        public virtual DbSet<KhachHangNu> KhachHangNus { get; set; }
        public virtual DbSet<ThongTinCheckInOut> ThongTinCheckInOuts { get; set; }
        public virtual DbSet<ThongTinDatPhong> ThongTinDatPhongs { get; set; }
        public virtual DbSet<ThongTinNhanVien> ThongTinNhanViens { get; set; }
        public virtual DbSet<XemCacPhongGiaDinh> XemCacPhongGiaDinhs { get; set; }
        public virtual DbSet<XemDichVu> XemDichVus { get; set; }
        public virtual DbSet<XemKhachHang> XemKhachHangs { get; set; }
        public virtual DbSet<XemTenPhong> XemTenPhongs { get; set; }
        public virtual DbSet<XemTienIch> XemTienIches { get; set; }
        public virtual DbSet<XemThongTinPhong1Giuong> XemThongTinPhong1Giuong { get; set; }
    
        public virtual ObjectResult<Nullable<decimal>> KiemTraDoanhThu(Nullable<System.DateTime> thang)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("KiemTraDoanhThu", thangParameter);
        }
    
        public virtual ObjectResult<KiemTraDV_Result> KiemTraDV(string tenDV)
        {
            var tenDVParameter = tenDV != null ?
                new ObjectParameter("TenDV", tenDV) :
                new ObjectParameter("TenDV", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KiemTraDV_Result>("KiemTraDV", tenDVParameter);
        }
    
        public virtual ObjectResult<KiemTraKH_Result> KiemTraKH(string tenKH)
        {
            var tenKHParameter = tenKH != null ?
                new ObjectParameter("TenKH", tenKH) :
                new ObjectParameter("TenKH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KiemTraKH_Result>("KiemTraKH", tenKHParameter);
        }
    
        public virtual ObjectResult<KiemTraPhong_Result> KiemTraPhong(Nullable<short> maPhong)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KiemTraPhong_Result>("KiemTraPhong", maPhongParameter);
        }
    
        public virtual ObjectResult<KiemTraTienIch_Result> KiemTraTienIch(string tenTI)
        {
            var tenTIParameter = tenTI != null ?
                new ObjectParameter("TenTI", tenTI) :
                new ObjectParameter("TenTI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KiemTraTienIch_Result>("KiemTraTienIch", tenTIParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_NgayDatPhong_Result> sp_NgayDatPhong(Nullable<System.DateTime> nGAYDATPHONG)
        {
            var nGAYDATPHONGParameter = nGAYDATPHONG.HasValue ?
                new ObjectParameter("NGAYDATPHONG", nGAYDATPHONG) :
                new ObjectParameter("NGAYDATPHONG", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_NgayDatPhong_Result>("sp_NgayDatPhong", nGAYDATPHONGParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_ThemNhanVien(string hOTEN, string gIOITINH, Nullable<System.DateTime> nGAYSINH, string dIACHI, Nullable<short> mACHUCVU, Nullable<short> mATAIKHOAN)
        {
            var hOTENParameter = hOTEN != null ?
                new ObjectParameter("HOTEN", hOTEN) :
                new ObjectParameter("HOTEN", typeof(string));
    
            var gIOITINHParameter = gIOITINH != null ?
                new ObjectParameter("GIOITINH", gIOITINH) :
                new ObjectParameter("GIOITINH", typeof(string));
    
            var nGAYSINHParameter = nGAYSINH.HasValue ?
                new ObjectParameter("NGAYSINH", nGAYSINH) :
                new ObjectParameter("NGAYSINH", typeof(System.DateTime));
    
            var dIACHIParameter = dIACHI != null ?
                new ObjectParameter("DIACHI", dIACHI) :
                new ObjectParameter("DIACHI", typeof(string));
    
            var mACHUCVUParameter = mACHUCVU.HasValue ?
                new ObjectParameter("MACHUCVU", mACHUCVU) :
                new ObjectParameter("MACHUCVU", typeof(short));
    
            var mATAIKHOANParameter = mATAIKHOAN.HasValue ?
                new ObjectParameter("MATAIKHOAN", mATAIKHOAN) :
                new ObjectParameter("MATAIKHOAN", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemNhanVien", hOTENParameter, gIOITINHParameter, nGAYSINHParameter, dIACHIParameter, mACHUCVUParameter, mATAIKHOANParameter);
        }
    
        public virtual int sp_ThemPhong(Nullable<short> mAPHONG, Nullable<short> mALOAI, Nullable<short> sOGIUONG, string hINHANH, Nullable<decimal> dONGIA, string mOTATHONGTIN, string tRANGTHAI)
        {
            var mAPHONGParameter = mAPHONG.HasValue ?
                new ObjectParameter("MAPHONG", mAPHONG) :
                new ObjectParameter("MAPHONG", typeof(short));
    
            var mALOAIParameter = mALOAI.HasValue ?
                new ObjectParameter("MALOAI", mALOAI) :
                new ObjectParameter("MALOAI", typeof(short));
    
            var sOGIUONGParameter = sOGIUONG.HasValue ?
                new ObjectParameter("SOGIUONG", sOGIUONG) :
                new ObjectParameter("SOGIUONG", typeof(short));
    
            var hINHANHParameter = hINHANH != null ?
                new ObjectParameter("HINHANH", hINHANH) :
                new ObjectParameter("HINHANH", typeof(string));
    
            var dONGIAParameter = dONGIA.HasValue ?
                new ObjectParameter("DONGIA", dONGIA) :
                new ObjectParameter("DONGIA", typeof(decimal));
    
            var mOTATHONGTINParameter = mOTATHONGTIN != null ?
                new ObjectParameter("MOTATHONGTIN", mOTATHONGTIN) :
                new ObjectParameter("MOTATHONGTIN", typeof(string));
    
            var tRANGTHAIParameter = tRANGTHAI != null ?
                new ObjectParameter("TRANGTHAI", tRANGTHAI) :
                new ObjectParameter("TRANGTHAI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemPhong", mAPHONGParameter, mALOAIParameter, sOGIUONGParameter, hINHANHParameter, dONGIAParameter, mOTATHONGTINParameter, tRANGTHAIParameter);
        }
    
        public virtual int sp_ThemTaiKhoan(string uSERNAME, string pASSWORDD, Nullable<short> mAPQ, Nullable<short> mAKH, Nullable<short> mANV)
        {
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            var pASSWORDDParameter = pASSWORDD != null ?
                new ObjectParameter("PASSWORDD", pASSWORDD) :
                new ObjectParameter("PASSWORDD", typeof(string));
    
            var mAPQParameter = mAPQ.HasValue ?
                new ObjectParameter("MAPQ", mAPQ) :
                new ObjectParameter("MAPQ", typeof(short));
    
            var mAKHParameter = mAKH.HasValue ?
                new ObjectParameter("MAKH", mAKH) :
                new ObjectParameter("MAKH", typeof(short));
    
            var mANVParameter = mANV.HasValue ?
                new ObjectParameter("MANV", mANV) :
                new ObjectParameter("MANV", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemTaiKhoan", uSERNAMEParameter, pASSWORDDParameter, mAPQParameter, mAKHParameter, mANVParameter);
        }
    
        public virtual ObjectResult<sp_ThongTinDatPhong_Result> sp_ThongTinDatPhong(Nullable<short> mADATPHONG)
        {
            var mADATPHONGParameter = mADATPHONG.HasValue ?
                new ObjectParameter("MADATPHONG", mADATPHONG) :
                new ObjectParameter("MADATPHONG", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ThongTinDatPhong_Result>("sp_ThongTinDatPhong", mADATPHONGParameter);
        }
    
        public virtual ObjectResult<sp_ThongTinDatPhongThanhCong_Result> sp_ThongTinDatPhongThanhCong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ThongTinDatPhongThanhCong_Result>("sp_ThongTinDatPhongThanhCong");
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<sp_XemChiTietKhachHang_Result> sp_XemChiTietKhachHang(Nullable<short> maKH)
        {
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_XemChiTietKhachHang_Result>("sp_XemChiTietKhachHang", maKHParameter);
        }
    
        public virtual ObjectResult<sp_XemDonGiaPhong_Result> sp_XemDonGiaPhong(Nullable<short> maPhong)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_XemDonGiaPhong_Result>("sp_XemDonGiaPhong", maPhongParameter);
        }
    
        public virtual ObjectResult<sp_XemThongTinKhachHang_Result> sp_XemThongTinKhachHang(string hoTen)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_XemThongTinKhachHang_Result>("sp_XemThongTinKhachHang", hoTenParameter);
        }
    
        public virtual ObjectResult<sp_XemThongTinPhong_Result> sp_XemThongTinPhong(Nullable<short> maPhong)
        {
            var maPhongParameter = maPhong.HasValue ?
                new ObjectParameter("MaPhong", maPhong) :
                new ObjectParameter("MaPhong", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_XemThongTinPhong_Result>("sp_XemThongTinPhong", maPhongParameter);
        }
    
        public virtual int ThemDichVu(string tenDV, string loaiDV)
        {
            var tenDVParameter = tenDV != null ?
                new ObjectParameter("TenDV", tenDV) :
                new ObjectParameter("TenDV", typeof(string));
    
            var loaiDVParameter = loaiDV != null ?
                new ObjectParameter("LoaiDV", loaiDV) :
                new ObjectParameter("LoaiDV", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemDichVu", tenDVParameter, loaiDVParameter);
        }
    
        public virtual ObjectResult<sp_GetAllPhong_Result> sp_GetAllPhong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllPhong_Result>("sp_GetAllPhong");
        }
    }
}
