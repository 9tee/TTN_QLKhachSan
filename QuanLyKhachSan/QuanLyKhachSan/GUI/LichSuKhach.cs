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
    public partial class LichSuKhach : Form
    {

        private int maKhach;

        public int MaKhach { get => maKhach; set => maKhach = value; }


        public LichSuKhach()
        {
            InitializeComponent();
        }
        public LichSuKhach(int makh)
        {
            this.maKhach = makh;
            InitializeComponent();
        }

        private void LichSuKhach_Load(object sender, EventArgs e)
        {
            dataGridViewLichSuCuaKhach.DataSource = DataProvider.Instance.ExecuteQuery("PROC_LichSuThue '" + maKhach + "'");
            dataGridViewLichSuCuaKhach.Columns["NgayDen"].ReadOnly = true;
            dataGridViewLichSuCuaKhach.Columns["NgayDi"].ReadOnly = true;
            dataGridViewLichSuCuaKhach.Columns["MaP"].ReadOnly = true;

            dataGridViewLichSuCuaKhach.Columns["NgayDen"].HeaderText = "Ngày Đến";
            dataGridViewLichSuCuaKhach.Columns["NgayDi"].HeaderText = "Ngày Đi";
            dataGridViewLichSuCuaKhach.Columns["MaP"].HeaderText = "Mã Phòng";
        }
    }
}
