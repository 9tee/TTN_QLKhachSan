using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    //khách hàng mới đến thì dùng thêm khách hàng, khách hàng đã đến thì dùng đặt phòng để chọn phòng,
    //khi khách hàng đến thì checkin, đi thì check-out, trong trường hợp huỷ phòng thì cx dùng checkout để huỷ
    //lịch sử là số phòng khách hàng đã đến
    //khách hàng được lựa chọn ở bên dataview bên dưới, tìm kiếm áp dụng cho các trường cmt sdt và tên khách hàng
    //Khi check out thì lựa chọn xem khách hàng là dạng trả phòng hay huỷ phòng, nếu là trả phòng sẽ gọi đến form
    //dịch vụ để thanh toán dịch vụ cùng với đó hiện 1 messagebox về chi tiết hoá đơn của khách
    public partial class MainForm : Form
    {
        private int maPhong;
        private int maKhach;
        public string tenKhach;
        public string soDienThoai;
        public string chungMinhThu;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int MaKhach { get => maKhach; set => maKhach = value; }


        #region Method
        public MainForm()
        {
            InitializeComponent();
            dataGridViewMainForm.DataSource = DataProvider.Instance.ExecuteQuery("PROC_XemTatKhachHang");
        }

        public MainForm(int maKH, int maP)
        {
            this.maKhach = maKH;
            this.maPhong = maP;
        }

        public static DataTable LoadKhachHang()
        {
            return DataProvider.Instance.ExecuteQuery("PROC_XemTatKhachHang");
        }


        #endregion




        #region Event

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNN_QLKSDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.tNN_QLKSDataSet.KhachHang);

        }

        private void addKHBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemKhachHang formThemKH = new ThemKhachHang();
            formThemKH.FormClosed += FormThemKH_FormClosed;
            formThemKH.Show();
        }

        private void FormThemKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        

        private void checkOutBt_Click(object sender, EventArgs e)
        {
            decimal tien;
            int a;
            DataGridViewRow currentRow = dataGridViewMainForm.CurrentRow;
            tien = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar("PROC_KiemTraDaCheckOut '"+ Convert.ToInt32(currentRow.Cells[0].Value) + "'"));
            a = Convert.ToInt32(tien);
            if (tien == 0)
            {
                DataProvider.Instance.ExecuteNonQuery("PROC_CheckOut '" + Convert.ToInt32(currentRow.Cells[0].Value) + "'");
                MessageBox.Show("-----Thanh Cong!-----");
            }
            else
            {
                MessageBox.Show("Khach nay da thanh toan . Ban co muon check-in moi?");
            }
        
        }

        private void datTruocBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewRow currentRow = dataGridViewMainForm.CurrentRow;
            ChonPhong formChonPhong = new ChonPhong();
            formChonPhong.MaKhachHang = Convert.ToInt32(currentRow.Cells[0].Value);
            formChonPhong.FormClosed += FormChonPhong_FormClosed;
            formChonPhong.Show();
        }

        private void checkInBt_Click(object sender, EventArgs e)
        {
            
                int ma1;
                int ma2;
                DataGridViewRow currentRow = dataGridViewMainForm.CurrentRow;
                ma1 = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("PROC_KiemTratruockhiCheckIn '" + Convert.ToInt32(currentRow.Cells[0].Value) + "'"));
                ma2 = Convert.ToInt32(currentRow.Cells[0].Value);

                if (maKhach != null && maPhong != null && maKhach != 0 && maPhong != 0)
                {
                    if (ma1 != ma2)
                    {
                        DataProvider.Instance.ExecuteNonQuery("PROC_TaoHoaDon '" + maKhach + "','" + maPhong + "'");
                        MessageBox.Show("-----Thanh Cong!-----");
                    }
                    else
                    {
                        MessageBox.Show("Khong Cho Phep 1 Khach Thue Nhieu Phong 1 Luc Khi Chua Thanh Toan !");
                    }
                    
                }
                else
                {
                    MessageBox.Show(" ! Chua chon khach hoac phong");
                }
            
            
        }

        private void FormChonPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void lichSuBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewRow currentRow = dataGridViewMainForm.CurrentRow;
            LichSuKhach lichSuKhachForm = new LichSuKhach();
            lichSuKhachForm.MaKhach = Convert.ToInt32(currentRow.Cells[0].Value);
            lichSuKhachForm.FormClosed += LichSuKhachForm_FormClosed;
            lichSuKhachForm.Show();
        }

        private void LichSuKhachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void timBt_Click(object sender, EventArgs e)
        {
            if (timKiemTb.Text == "")
            {
                MessageBox.Show("Phải nhập thông tin");
            }
            else
            {
                if (comboBox_LoaiThongTin.Text == "")
                {
                    MessageBox.Show("Phải chọn loại thông tin");
                }
                else
                {
                    if (comboBox_LoaiThongTin.Text == "CMT")
                    {
                        dataGridView1.DataSource = KhachHangController.TKKhachHangCMT(timKiemTb.Text);
                    }
                    else if (comboBox_LoaiThongTin.Text == "SĐT")
                    {
                        dataGridView1.DataSource = KhachHangController.TKKhachHangSDT(timKiemTb.Text);
                    }
                    else if (comboBox_LoaiThongTin.Text == "Họ tên")
                    {
                        dataGridView1.DataSource = KhachHangController.TKKhachHangHoTen(timKiemTb.Text);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KhachHangController.HTTatCaKhachHang();
        }


        #endregion

        
    }
}
