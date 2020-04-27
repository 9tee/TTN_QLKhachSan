using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class PhongController
    {
        public static List<Phong> ConvertToPhong(DataTable dt)
        {
            List<Phong> lp = new List<Phong>();
            lp = (from DataRow dr in dt.Rows
                    select
                        new Phong()
                        {
                            MaP = Convert.ToInt32(dr["MaP"]),
                            GiaPhongGio = (decimal)dr["GiaPhongGio"],
                            GiaPhongNgay = (decimal)dr["GiaPhongNgay"],
                            Tang = Convert.ToInt32(dr["Tang"]),
                            Trong = Convert.ToBoolean(dr["Trong"])
                        }).ToList();
            return lp;
        }
        public static List<Phong> HienTatCaPhong()
        {
            string query = "select * from Phong";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return ConvertToPhong(dt);
        }
        public static List<Phong> HienTatCaPhongVaKTNgay(DateTime NgayDen,DateTime NgayDi)
        {
            List<Phong> lp = HienTatCaPhong();
            foreach(Phong p in lp)
            {
                List<HoaDonPhong> lhdp = HoaDonPhongController.DSHoaDonPhong_1_Phong(p);
                if (HoaDonPhongController.KTNgay(lhdp, NgayDen, NgayDi) == true)
                {
                    p.Trong = true;
                }
                else
                    p.Trong = false;
            }
            return lp; 
        }
    }
}
