using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int rowIndexDS = 0;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int MaKhach { get => maKhach; set => maKhach = value; }



        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(int maKH, int maP)
        {
            this.maKhach = maKH;
            this.maPhong = maP;
        }
        private void addKHBt_Click(object sender, EventArgs e)
        {

            ThemKhachHang formThemKhachHang = new ThemKhachHang();
            //formThemKhachHang.FormClosed += FormThemKhachHang_FormClosed;
            formThemKhachHang.ShowDialog();
        }

        private void checkInBt_Click(object sender, EventArgs e)
        {
            int maKhachHangHienTai;
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            maKhachHangHienTai = Convert.ToInt32(currentRow.Cells[3].Value);
            
            
            if (maKhachHangHienTai != 0)
            {
                try
                {
                    string checkTrangThaiPhong = DataProvider.Instance.ExecuteScalar("PROC_KiemTraTrangThaiPhong '" + maKhachHangHienTai + "'").ToString();
                    if (checkTrangThaiPhong == "Đa Nhan Phong")
                    {
                        MessageBox.Show("Đã Nhận Phòng");
                    }
                    else if (checkTrangThaiPhong == "Đa Tra Phong")
                    {
                        MessageBox.Show("Đã Trả Phòng");
                    }
                    else if (checkTrangThaiPhong == "Huy")
                    {
                        MessageBox.Show("Đã Hủy Phòng");
                    }
                    else if(checkTrangThaiPhong == "Chua Nhan Phong")
                    {
                        DataProvider.Instance.ExecuteNonQuery("PROC_CheckIn '" + maKhachHangHienTai + "'");
                        MessageBox.Show("-----Đã Đặt Phòng Thành Công!-----");
                    }
                    else
                    {
                        MessageBox.Show("Không Hợp Lệ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Không có dữ liệu đặt phòng của khách !");
                }


            }
            else
            {
                MessageBox.Show(" ! Chưa chọn khách hàng");
            }
        }


        private void checkOutBt_Click(object sender, EventArgs e)
        {
            decimal tien;
            int maKhachHangHienTai;
            DataGridViewRow currentRow = dataGridView1.CurrentRow;


            maKhachHangHienTai = Convert.ToInt32(currentRow.Cells[3].Value);
            tien = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar("PROC_KiemTraDaCheckOut '" + maKhachHangHienTai + "'"));
            

            if (maKhachHangHienTai != 0)
            {
                try
                {
                    string checkTrangThaiPhong = DataProvider.Instance.ExecuteScalar("PROC_KiemTraTrangThaiPhong '" + maKhachHangHienTai + "'").ToString();
                    if (tien == 0 && checkTrangThaiPhong != null)
                    {
                        DataProvider.Instance.ExecuteNonQuery("PROC_CheckOut '" + maKhachHangHienTai + "'");
                        MessageBox.Show("-----Thành Công!-----");
                    }
                    else
                    {
                        MessageBox.Show("Khách này đã thanh toán . Bạn có muốn check-in mới?");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Không có dữ liệu đặt phòng của khách !");
                }
            }
            else
            {
                MessageBox.Show(" ! Chưa chọn khách hàng");
            }

        }


        private void datTruocBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            ThemKhachHang themKhachHang = new ThemKhachHang(
                currentRow.Cells[0].Value.ToString(),
                currentRow.Cells[1].Value.ToString(),
                currentRow.Cells[2].Value.ToString(),
                Convert.ToInt32(currentRow.Cells[3].Value)
                );
            themKhachHang.FormClosed += ThemKhachHang_FormClosed;
            themKhachHang.Show();
            //formChonPhong.MaKhachHang = Convert.ToInt32(currentRow.Cells[0].Value);

        }

        private void ThemKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void lichSuBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            LichSuKhach lichSuKhachForm = new LichSuKhach();
            lichSuKhachForm.MaKhach = Convert.ToInt32(currentRow.Cells[3].Value);
            lichSuKhachForm.FormClosed += LichSuKhachForm_FormClosed;
            lichSuKhachForm.Show();
        }
        private void LichSuKhachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void timBt_Click(object sender, EventArgs e)
        {
            string tktext = timKiemTb.Text;
            if (tktext == "")
            {
                MessageBox.Show("Phải nhập thông tin");
            }
            else
            {
                List<KhachHang> lkh = new List<KhachHang>();
                lkh.AddRange(KhachHangController.TKKhachHangCMT(tktext));
                lkh.AddRange(KhachHangController.TKKhachHangHoTen(tktext));
                lkh.AddRange(KhachHangController.TKKhachHangSDT(tktext));
                lkh = lkh.Distinct().ToList();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KhachHangController.HTTatCaKhachHang();
            dataGridView1.Columns[0].HeaderText = "Tên Khách Hàng";
            dataGridView1.Columns[1].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[2].HeaderText = "Chứng Minh Thư";
            dataGridView1.Columns[3].HeaderText = "Mã Khách Hàng";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    rowIndexDS = Convert.ToInt32(currentMouseOverRow.ToString());
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void theToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVuVaDoDung dichVuVaDoDung = new DichVuVaDoDung(1);
            dichVuVaDoDung.FormClosed += DichVuVaDoDung_FormClosed;
            this.Hide();
            dichVuVaDoDung.Show();
        }

        private void DichVuVaDoDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
