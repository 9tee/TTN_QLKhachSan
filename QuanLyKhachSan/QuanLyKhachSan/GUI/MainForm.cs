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
        public MainForm()
        {
            InitializeComponent();
        }

        private void addKHBt_Click(object sender, EventArgs e)
        {

            ThemKhachHang formThemKhachHang = new ThemKhachHang();
            //formThemKhachHang.FormClosed += FormThemKhachHang_FormClosed;
            formThemKhachHang.ShowDialog();
        }

        private void checkInBt_Click(object sender, EventArgs e)
        {

        }

        private void checkOutBt_Click(object sender, EventArgs e)
        {

        }

        private void datTruocBt_Click(object sender, EventArgs e)
        {

        }

        private void lichSuBt_Click(object sender, EventArgs e)
        {

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
        }
    }
}
