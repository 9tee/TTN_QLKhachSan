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
    public partial class DichVuVaDoDung : Form
    {
        private Control_DVDD con = new Control_DVDD();
        private List<DichVu> dvs = new List<DichVu>();
        private List<DoDung> dds = new List<DoDung>();
        private List<SuDung> sds = new List<SuDung>();
        private List<DanhSachDVDD> ds = new List<DanhSachDVDD>();
        private int rowIndexDS = 0;
        private int rowIndex = 0;
        private int mahd;


        public DichVuVaDoDung(int MaHoaDon)
        {
            mahd = MaHoaDon;
            InitializeComponent();
        }

        private void themBt_Click(object sender, EventArgs e)
        {
            if(textBoxSoLuong.Text != "0" && textBoxSoLuong.Text != "Nhập số khác 0")
            {
                if (comboBoxChon.SelectedItem.ToString() == "Đồ Dùng")
                {
                    DoDung dd = dds[rowIndex];
                    decimal tong = Convert.ToInt32(textBoxSoLuong.Text) * dd.Gia;
                    DanhSachDVDD them = new DanhSachDVDD(dd.Ma,dd.Ten,Convert.ToInt32(textBoxSoLuong.Text),tong, true);
                    ds.Add(them);
                }
                else if (comboBoxChon.SelectedItem.ToString() == "Dịch Vụ")
                {
                    DichVu dv = dvs[rowIndex];
                    decimal tong = Convert.ToInt32(textBoxSoLuong.Text) * dv.Gia;
                    DanhSachDVDD them = new DanhSachDVDD(dv.Ma, dv.Ten, Convert.ToInt32(textBoxSoLuong.Text), tong, false);
                    ds.Add(them);
                }
                else if (comboBoxChon.SelectedItem.ToString() == "Tất Cả")
                {
                    SuDung sd = sds[rowIndex];
                    decimal tong = Convert.ToInt32(textBoxSoLuong.Text) * sd.Gia;
                    bool check = true;
                    foreach(DichVu item in dvs)
                    {
                        if(item.Ma == sd.Ma)
                        {
                            check = false;
                        }
                    }
                    DanhSachDVDD them = new DanhSachDVDD(sd.Ma, sd.Ten, Convert.ToInt32(textBoxSoLuong.Text), tong, check);
                    ds.Add(them);
                }
                GetDSChon();
                themBt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Số lượng phải khác 0!");
            }
            textBoxSoLuong.Text = "Nhập số khác 0";
            textBoxSoLuong.ForeColor = Color.Gray;
            xacNhanBt.Enabled = true;
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            con.LuuDanhSachSuDung(ds, mahd);
        }
        private void GetDSDD()
        {
            dataGridViewChon.DataSource = null;
            dataGridViewChon.DataSource = dds;
            dataGridViewChon.Columns[1].HeaderText = "Tên Đồ Dùng";
            dataGridViewChon.Columns[2].HeaderText = "Giá";
            dataGridViewChon.Columns[3].HeaderText = "Đơn Vị";
            dataGridViewChon.Columns[0].Visible = false;
        }
        private void GetDSDV()
        {
            dataGridViewChon.DataSource = null;
            dataGridViewChon.DataSource = dvs;
            dataGridViewChon.Columns[1].HeaderText = "Tên Dịch Vụ";
            dataGridViewChon.Columns[2].HeaderText = "Giá";
            dataGridViewChon.Columns[0].Visible = false;
        }
        private void GetDSChon()
        {
            dataGridViewDanhSach.DataSource = null;
            dataGridViewDanhSach.DataSource = ds;
            dataGridViewDanhSach.Columns[1].HeaderText = "Tên";
            dataGridViewDanhSach.Columns[2].HeaderText = "Số Lượng";
            dataGridViewDanhSach.Columns[3].HeaderText = "Thành Tiền";
            dataGridViewDanhSach.Columns[0].Visible = false;
            dataGridViewDanhSach.Columns[4].Visible = false;
        }
        private void GetDSTatCa()
        {
            dataGridViewChon.DataSource = null;
            dataGridViewChon.DataSource = sds;
            dataGridViewChon.Columns[1].HeaderText = "Tên ";
            dataGridViewChon.Columns[2].HeaderText = "Giá";
            dataGridViewChon.Columns[0].Visible = false;
        }

        private void DichVuVaDoDung_Load(object sender, EventArgs e)
        {
            dvs = con.GetDanhSachDichVu();
            dds = con.GetDanhSachDichDung();
            sds = con.GetDanhSachSuDung();
            comboBoxChon.SelectedItem = "Tất Cả";
            GetDSTatCa();
        }

        private void comboBoxChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxChon.SelectedItem.ToString() == "Đồ Dùng")
            {
                GetDSDD();
            }
            else if(comboBoxChon.SelectedItem.ToString() == "Dịch Vụ")
            {
                GetDSDV();
            }
            else if(comboBoxChon.SelectedItem.ToString() == "Tất Cả")
            {
                GetDSTatCa();
            }
            themBt.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSoLuong_Enter(object sender, EventArgs e)
        {
            if(textBoxSoLuong.Text == "Nhập số khác 0")
            {
                textBoxSoLuong.Text = "";
                textBoxSoLuong.ForeColor = Color.Black;
            }
        }

        private void textBoxSoLuong_Leave(object sender, EventArgs e)
        {
            if (textBoxSoLuong.Text == "")
            {
                textBoxSoLuong.Text = "Nhập số khác 0";
                textBoxSoLuong.ForeColor = Color.Gray;
            }
        }

        private void dataGridViewChon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            themBt.Enabled = true;
            rowIndex = e.RowIndex;
        }

        private void dataGridViewDanhSach_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewDanhSach.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    rowIndexDS = Convert.ToInt32( currentMouseOverRow.ToString());
                    contextMenuStrip1.Show(dataGridViewDanhSach, new Point(e.X, e.Y));
                }
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.RemoveAt(rowIndexDS);
            GetDSChon();
            if (ds.Count == 0)
            {
                xacNhanBt.Enabled = false;
            }
        }
    }
}
