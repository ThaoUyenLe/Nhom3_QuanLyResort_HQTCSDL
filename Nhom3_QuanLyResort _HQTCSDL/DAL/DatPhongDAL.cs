using Nhom3_QuanLyResort__HQTCSDL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Nhom3_QuanLyResort__HQTCSDL.DAL
{
    public class DatPhongDAL
    {
        string connStr = ConfigurationManager.ConnectionStrings["ResortDb_conn"].ToString();
        public List<DatPhong> xemDatPhong()
        {

            List<DatPhong> datPhongs = new List<DatPhong>();
            using (SqlConnection connecttion = new SqlConnection(connStr))
            {
                SqlCommand cmd = connecttion.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDatPhong";
                SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);
                DataTable dtDichVu = new DataTable();
                connecttion.Open();

                sqlDA.Fill(dtDichVu);
                connecttion.Close();

                foreach (DataRow item in dtDichVu.Rows)
                {
                    datPhongs.Add(new DatPhong
                    {
                        MaDatPhong = (short)Convert.ToInt32(item["MaDichVu"].ToString()),
                        MaPhong = (short)Convert.ToInt32(item["MaPhong"].ToString()),
                        MaPhieuXacNhan = (short)Convert.ToInt32(item["MaPhieuXacNhan"].ToString()),
                        TenKH = item["TenKH"].ToString(),
                        NgayDatPhong = Convert.ToDateTime(item["NgayDatPhong"]),
                        NgayTraPhong = Convert.ToDateTime(item["NgayTraPhong"]),
                        YeuCauThem = item["YeuCauThem"].ToString()
                    });
                }
            }

            return datPhongs;
        }

        public bool themDatPhong(DatPhong datPhong)
        {
            int id = 0;
            using (SqlConnection connecttion = new SqlConnection(connStr))
            {
                SqlCommand cmd = connecttion.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemDonDatPhong";
                cmd.Parameters.AddWithValue("@MaPhong", datPhong.MaPhong);
                cmd.Parameters.AddWithValue("@MaPhuongThuc", datPhong.MaPhuongThuc);
                cmd.Parameters.AddWithValue("@MaPhieuXacNhan", datPhong.MaPhieuXacNhan);
                cmd.Parameters.AddWithValue("@TenKH", datPhong.TenKH);
                cmd.Parameters.AddWithValue("@NgayDatPhong", datPhong.NgayDatPhong);
                cmd.Parameters.AddWithValue("@NgayTraPhong", datPhong.NgayTraPhong);
                cmd.Parameters.AddWithValue("@YeuCauThem", datPhong.YeuCauThem);

                connecttion.Open();

                id = cmd.ExecuteNonQuery();

                connecttion.Close();

                if (id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
                    
            }
        }

        public bool suaDatPhong(DatPhong datPhong)
        {
            int id = 0;
            using (SqlConnection connecttion = new SqlConnection(connStr))
            {
                SqlCommand cmd = connecttion.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaDonDatPhong";
                cmd.Parameters.AddWithValue("@MaDatPhong", datPhong.MaDatPhong);
                cmd.Parameters.AddWithValue("@MaPhong", datPhong.MaPhong);
                cmd.Parameters.AddWithValue("@MaPhuongThuc", datPhong.MaPhuongThuc);
                cmd.Parameters.AddWithValue("@MaPhieuXacNhan", datPhong.MaPhieuXacNhan);
                cmd.Parameters.AddWithValue("@TenKH", datPhong.TenKH);
                cmd.Parameters.AddWithValue("@NgayDatPhong", datPhong.NgayDatPhong);
                cmd.Parameters.AddWithValue("@NgayTraPhong", datPhong.NgayTraPhong);
                cmd.Parameters.AddWithValue("@YeuCauThem", datPhong.YeuCauThem);

                connecttion.Open();

                 id = cmd.ExecuteNonQuery();

                connecttion.Close();

                if (id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public bool xoaDatPhong(DatPhong datPhong)
        {
            int id = 0;
            using (SqlConnection connecttion = new SqlConnection(connStr))
            {
                SqlCommand cmd = connecttion.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaDonDatPhong";
                cmd.Parameters.AddWithValue("@MaDatPhong", datPhong.MaDatPhong);

                connecttion.Open();

                id = cmd.ExecuteNonQuery();

                connecttion.Close();

                if (id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}