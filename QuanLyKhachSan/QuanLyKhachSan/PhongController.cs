using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    class PhongController
    {
        public static List<Phong> Convert_DTToPhong(DataTable dt)
        {
            /*List<DoDung> dds = new List<DoDung>();
            dds = (from DataRow dr in datatable.Rows
                   select new DoDung()
                   {
                       Ma = dr["MaDD"].ToString(),
                       Ten = dr["TenDD"].ToString(),
                       Gia = (decimal)dr["Gia"],
                       DonVi = dr["DonVi"].ToString()
                   }).ToList();
            return dds;*/
            List<Phong> lp = new List<Phong>();
            lp = (from DataRow dr in dt.Rows
                select new Phong()
                {
                    MaP = Convert.ToInt32(dr["MaP"]),
                    GiaPhongNgay = (decimal)dr["GiaPhongNgay"],
                    GiaPhongGio = (decimal)dr["GiaPhongGio"],
                    Tang = Convert.ToInt32(dr["Tang"]),
                    Trong = Convert.ToBoolean(dr["Trong"])
                }).ToList();
            return lp;
        }
        public static List<Phong> HienTatCaPhong()
        {
            string query = "select * from Phong";
            return Convert_DTToPhong(DataProvider.Instance.ExecuteQuery(query));
        }
        public static List<Phong> HienTatCaPhongVaKTNgay(DateTime NgayDen, DateTime NgayDi)
        {
            List<Phong> DSTatCaPhong = HienTatCaPhong();
            List<Phong> DSPhongTrong = new List<Phong>();
            foreach (Phong p in DSTatCaPhong)
            {
                List<HoaDonPhong> lhdp = HoaDonPhongController.DSHoaDonPhong_1_Phong(p);
                if (HoaDonPhongController.KTNgay(lhdp, NgayDen, NgayDi) == true)
                {
                    p.Trong = true;
                    DSPhongTrong.Add(p);
                }
                else
                    //lp.Remove(p);
                    p.Trong = false;
            }
            
            return DSPhongTrong;
        }
    }
}
