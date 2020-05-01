using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKhachSan
{
    class Control_DVDD
    {
        public List<DoDung> ConvertDD(DataTable datatable)
        {
            List<DoDung> dds = new List<DoDung>();
            dds = (from DataRow dr in datatable.Rows
                    select new DoDung()
                    {
                        Ma = dr["MaDD"].ToString(),
                        Ten = dr["TenDD"].ToString(),
                        Gia = (decimal)dr["Gia"],
                        DonVi = dr["DonVi"].ToString()
                    }).ToList();
            return dds;
        }
        public List<DichVu> ConvertDV(DataTable datatable)
        {
            List<DichVu> dvs = new List<DichVu>();
            dvs = (from DataRow dr in datatable.Rows
                   select new DichVu()
                   {
                       Ma = dr["MaDV"].ToString(),
                       Ten = dr["TenDV"].ToString(),
                       Gia = (decimal)dr["Gia"]
                   }).ToList();
            return dvs;
        }
        public List<SuDung> ConvertSS(DataTable tbdd, DataTable tbdv)
        {
            List<SuDung> ss = new List<SuDung>();
            List<DichVu> dvs = new List<DichVu>();
            dvs = ConvertDV(tbdv);
            List<DoDung> dds = new List<DoDung>();
            dds = ConvertDD(tbdd);
            foreach(SuDung item in dds)
            {
                ss.Add(item);
            }
            foreach (SuDung item in dvs)
            {
                ss.Add(item);
            }
            return ss;
        }
        public List<DichVu> GetDanhSachDichVu()
        {
            //viết proc lấy ds dịch vụ
            DataTable data;
            string query = "select * from DichVu";
            data = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDV(data);
        }
        public List<DoDung> GetDanhSachDichDung()
        {
            //viết proc lấy ds đồ dùng
            DataTable data;
            string query = "select * from DoDung";
            data = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDD(data);
        }
        public List<SuDung> GetDanhSachSuDung()
        {
            DataTable datadd;
            string query1 = "select * from DoDung";
            DataTable datadv;
            string query2 = "select * from DichVu";
            datadd = DataProvider.Instance.ExecuteQuery(query1);
            datadv = DataProvider.Instance.ExecuteQuery(query2);
            return ConvertSS(datadd,datadv);
        }
        public bool LuuDanhSachSuDung(List<DanhSachDVDD> ds, int mahd)
        {
            try
            {
                foreach(DanhSachDVDD item in ds)
                {
                    if (item.Check == true)
                    {
                        // viết proc lưu xuống hóa đơn đồ dùng
                        string query = "";
                        DataProvider.Instance.ExecuteQuery(query);
                    }
                    else
                    {
                        // viêt proc lưu xuống hóa đơn dịch vụ
                        string query = "";
                        DataProvider.Instance.ExecuteQuery(query);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
