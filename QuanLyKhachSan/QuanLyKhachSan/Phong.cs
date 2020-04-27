using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class Phong
    {
        public int maP;
        public decimal giaPhongNgay;
        public decimal giaPhongGio;
        public int tang;
        public bool trong;

        public Phong()
        {
            this.maP = 0;
            this.giaPhongNgay = 0;
            this.giaPhongGio = 0;
            this.tang = 1;
            this.trong = true;
        }
        public Phong(int maP,decimal giaPhongNgay,decimal giaPhongGio,int tang,bool trong)
        {
            this.maP = maP;
            this.giaPhongNgay = giaPhongNgay;
            this.giaPhongGio = giaPhongGio;
            this.tang = tang;
            this.trong = trong;
        }
        public int MaP { get => maP; set => maP = value; }
        public decimal GiaPhongNgay { get => giaPhongNgay; set => giaPhongNgay = value; }
        public decimal GiaPhongGio { get => giaPhongGio; set => giaPhongGio = value; }
        public int Tang { get => tang; set => tang = value; }
        public bool Trong { get => trong; set => trong = value; }
    }
}
