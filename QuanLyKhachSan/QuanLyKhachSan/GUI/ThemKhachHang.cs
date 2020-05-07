using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyKhachSan.GUI
{
    // 2 lựa chọn khi thêm mới kách hàng đặt phòng và khách hàng cũ đến đặt phòng
    
    public partial class ThemKhachHang : Form
    {
        public static List<Phong> PhongDuocChon = new List<Phong>();
        public static string NgayDen;
        public static string NgayDi;
        public static int MaKhachHang;

        public ThemKhachHang()
        {
            InitializeComponent();
            this.Name = "Thêm khách hàng";
        }

        public ThemKhachHang(string TenKhachHang, string SDT, string CMT,int MaKH)
        {
            InitializeComponent();
            this.Name = "Đặt phòng";
            tenKhachHangTb.Text = TenKhachHang;
            soDienThoaiTb.Text = SDT;
            soCMTTb.Text = CMT;
            MaKhachHang = MaKH;
        }

        private void XacNhanBt_Click(object sender, EventArgs e)
        {
            int maKHCheck;//kiem tra khach hang trong csdl co ngay tao mac dinh 1900/01/01 -> chua chot hoa don tong
            
            maKHCheck = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("PROC_KiemTraTruocKhiDatPhong '" + MaKhachHang + "'"));
            

            bool matchTenKH = Regex.IsMatch(tenKhachHangTb.Text, @"^\s");
            bool matchCMT = Regex.IsMatch(soCMTTb.Text, @"^\s");

            tenKhachHangTb.Text = tenKhachHangTb.Text.Trim();
            soCMTTb.Text = soCMTTb.Text.Trim();

            if (tenKhachHangTb.Text == "")
            {
                MessageBox.Show("Tên khách hàng không Được Để Trống");
                tenKhachHangTb.Focus();
            }
            else if (soCMTTb.Text == "")
            {
                MessageBox.Show("Số CMT không Được Để Trống");
                soCMTTb.Focus();
            }
            else
            {
                if (matchTenKH)
                {
                    MessageBox.Show("Tên khách hàng không Được Để Tất Cả Là Khoảng Trắng");
                    tenKhachHangTb.Focus();
                }
                else if (matchCMT)
                {
                    MessageBox.Show("Chứng minh thư không Được Để Tất Cả Là Khoảng Trắng");
                    soCMTTb.Focus();
                }
                else
                {
                    string ngayNhan = ngayNhanPicker.Value.ToString("yyyy-MM-dd"); //Lay ngay nhan phong
                    string ngayTra = ngayTraPicker.Value.ToString("yyyy-MM-dd");// Lay ngay tra phong
                    bool ngay;
                    if (theoNgayRb.Checked == true)
                    {
                        ngay = true;
                    }
                    else
                    {
                        ngay = false;
                    }//Lay cach thue
                    

                    if (phongDataGrid.Rows.Count == 0)
                    {
                        MessageBox.Show(" ! Chua chon phong");
                    }
                    else if (maKHCheck != MaKhachHang)
                    {

                        int soPhong = phongDataGrid.Rows.Count;
                        DataProvider.Instance.ExecuteNonQuery("PROC_TaoHoaDon '" + MaKhachHang + "'");
                        for (int rows = 0; rows < soPhong ; rows ++)
                        {
                            int maPhong = Convert.ToInt32(phongDataGrid.Rows[rows].Cells[0].Value.ToString());
                            DataProvider.Instance.ExecuteNonQuery("PROC_DatPhongTruoc '" + MaKhachHang + "','" + maPhong + "','" + ngayNhan + "','" + ngayTra + "','" + ngay + "'");
                            MessageBox.Show("-----Thanh Cong!-----");

                        }
                    }
                    else
                    {
                        MessageBox.Show("-----That Bai!-----");
                    }

                }
            }
        }

        private void ChonPhongBt_Click(object sender, EventArgs e)
        {
            NgayDen = ngayNhanPicker.Value.ToString("yyyy-MM-dd");
            NgayDi = ngayTraPicker.Value.ToString("yyyy-MM-dd");
            this.Hide();
            ChonPhong formChonPhong = new ChonPhong();
            formChonPhong.FormClosed += FormChonPhong_FormClosed;
            formChonPhong.ShowDialog();

            //phongDataGrid.DataSource = formChonPhong.maPhong;
            //phongDataGrid.Refresh();

        }
        private void FormChonPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            phongDataGrid.DataSource = PhongDuocChon;
        }

        private void HuyBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            theoGioRb.Checked = true;
        }
    }
}
