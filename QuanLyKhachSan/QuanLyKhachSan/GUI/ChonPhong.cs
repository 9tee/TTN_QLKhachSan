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

namespace QuanLyKhachSan.GUI
{
    public partial class ChonPhong : Form
    {
        //public static List<Phong> PhongDuocChon = new List<Phong>();
        public ChonPhong()
        {
            InitializeComponent();
        }

        private void ChonPhong_Load(object sender, EventArgs e)
        {
            //phongDataGrid.DataSource = xemPhong();
            //phongDataGrid.Refresh();
            phongDataGrid.DataSource = PhongController.HienTatCaPhongVaKTNgay(Convert.ToDateTime(ThemKhachHang.NgayDen), Convert.ToDateTime(ThemKhachHang.NgayDi));
            //phongDataGrid.Columns["MaP"].Visible = true;

            phongDataGrid.Columns["MaP"].ReadOnly = true;
            phongDataGrid.Columns["GiaPhongNgay"].ReadOnly = true;
            phongDataGrid.Columns["GiaPhongGio"].ReadOnly = true;
            phongDataGrid.Columns["Tang"].ReadOnly = true;
            phongDataGrid.Columns["Trong"].ReadOnly = true;
            phongDataGrid.Columns["checkPhong"].ReadOnly = false;

            phongDataGrid.Columns["GiaPhongNgay"].HeaderText = "Giá theo ngày";
            phongDataGrid.Columns["GiaPhongGio"].HeaderText = "Giá theo giờ";
            phongDataGrid.Columns["Tang"].HeaderText = "Tầng";
            phongDataGrid.Columns["Trong"].HeaderText = "Trống";
        }

        private void HuyBt_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        /*public List<Phong> OutputPhongDuocChon()
        {
            return PhongDuocChon;
        }*/
        private void XacNhanBt_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in phongDataGrid.Rows)
            //{
            //    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
            //    if (chk.Value != chk.FalseValue)
            //    {
            //        //MessageBox.Show(row.Cells[0].Value.ToString());
            //        //MessageBox.Show(row.Cells[2].Value.ToString());
            //        //MessageBox.Show(row.Cells[3].Value.ToString());
            //        //MessageBox.Show(row.Cells[4].Value.ToString());
            //        //MessageBox.Show(row.Cells[5].Value.ToString());
            //        maPhong.Add(new phong(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString()));
            //    }
            //}
            //this.Close();
            foreach(DataGridViewRow row in phongDataGrid.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    ThemKhachHang.PhongDuocChon.Add(new Phong(Convert.ToInt32(row.Cells[1].Value),
                        Convert.ToDecimal(row.Cells[2].Value), 
                        Convert.ToDecimal(row.Cells[3].Value), 
                        Convert.ToInt32(row.Cells[4].Value)));
                }

            }
            this.Close();
        }
    }
}
