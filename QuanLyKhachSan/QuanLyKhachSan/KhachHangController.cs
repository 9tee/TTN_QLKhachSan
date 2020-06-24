using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class KhachHangController
    {
        public static List<KhachHang> ConvertToKH(DataTable dt)
        {
            List<KhachHang> lkh = new List<KhachHang>();
            lkh = (from DataRow dr in dt.Rows
                   select
                        new KhachHang()
                        {
                            MaKH = Convert.ToInt32(dr["MaKH"]),
                            TenKH = dr["TenKH"].ToString(),
                            SDT = dr["SDT"].ToString(),
                            CMT = dr["CMT"].ToString()
                        }).ToList();
            return lkh;
        }
        public static List<KhachHang> TKKhachHangCMT(string CMT)
        {
            string query = "select * " +
                "from KhachHang " +
                "where " +
                $"CMT = {CMT}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return ConvertToKH(dt);
        }
        public static List<KhachHang> TKKhachHangSDT(string SDT)
        {
            string query = "select * " +
                "from KhachHang " +
                "where " +
                $"SDT = {SDT}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return ConvertToKH(dt);
        }
        public static List<KhachHang> TKKhachHangHoTen(string HoTen)
        {
            string query = "select * " +
                "from KhachHang " +
                "where " +
                $"TenKH like N'%{HoTen}%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return ConvertToKH(dt);
        }
        public static List<KhachHang> HTTatCaKhachHang()
        {
            string query = "select * " +
                "from KhachHang ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return ConvertToKH(dt);
        }
        public static int ThemKhachHang(string tenKH,string sdt, string cmt)
        {
            string query = "INSERT INTO [dbo].[KhachHang]([TenKH],[SDT],[CMT])VALUES(N'"+tenKH+"','"+sdt+"','"+cmt+"')";
            DataProvider.Instance.ExecuteNonQuery(query);
            query = "select max(MaKH) from KhachHang";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }

    }
}
