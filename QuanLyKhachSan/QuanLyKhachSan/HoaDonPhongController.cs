using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class HoaDonPhongController
    {
        public static List<HoaDonPhong> ConvertToHoaDonPhong(DataTable dt)
        {
            List<HoaDonPhong> lhdp = new List<HoaDonPhong>();
            lhdp = (from DataRow dr in dt.Rows
                    select
                        new HoaDonPhong()
                        {
                            MaP = Convert.ToInt32(dr["MaP"]),
                            MaHD = Convert.ToInt32(dr["MaHD"]),
                            NgayDen = Convert.ToDateTime(dr["NgayDen"]),
                            NgayDi = Convert.ToDateTime(dr["NgayDi"]),
                            Ngay = Convert.ToBoolean(dr["Ngay"]),
                            ThanhTien = (decimal)dr["ThanhTien"]
                        }).ToList();
            return lhdp;
        }
        public static List<HoaDonPhong> DSHoaDonPhong_1_Phong(Phong phong)
        {
            List<HoaDonPhong> lhdp = new List<HoaDonPhong>();
            lhdp = ConvertToHoaDonPhong(DataProvider.Instance.ExecuteQuery("" +
                "select * " +
                "from HoaDonPhong " +
                "where " +
                $"HoaDonPhong.MaP = {phong.MaP}"));
            return lhdp;
        }
        public static bool KTNgay(List<HoaDonPhong> lhdp,DateTime NgayDenM,DateTime NgayDiM)
        {
            bool check = true;
            // ngay den va ngay di -> phong trong
            foreach(HoaDonPhong hdp in lhdp)
            {
                if (hdp.NgayDen == NgayDenM)
                    check = false;
                else if (hdp.NgayDi == NgayDiM)
                    check = false;
                else if (NgayDenM > hdp.NgayDen)
                {
                    if (NgayDenM < hdp.NgayDi && NgayDiM > hdp.NgayDi)
                        check = false;
                    else if (NgayDiM < hdp.NgayDi)
                        check = false;
                }
                else if (NgayDiM < hdp.NgayDi)
                {
                    if (NgayDenM < hdp.NgayDen)
                        check = false;
                }
                else if (NgayDenM < hdp.NgayDen && NgayDiM > hdp.NgayDi)
                    check = false;       
            }
            return check;
        }
    }
}
