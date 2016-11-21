using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChiTietHoaDonNhapHang
    {
        //Thuộc tính lớp
        private int miMaCTHD; 
        private int miMaHDNhaphang;   
        private int miMaNVL;     
        private int miSL;     
        private int miGia;     
        private int miTongtien;

        //Phương thức get set của lớp
        public int MiMaCTHD
        {
            get { return miMaCTHD; }
            set { miMaCTHD = value; }
        }
        public int MiMaHDNhaphang
        {
            get { return miMaHDNhaphang; }
            set { miMaHDNhaphang = value; }
        }
        public int MiMaNVL
        {
            get { return miMaNVL; }
            set { miMaNVL = value; }
        }
        public int MiSL
        {
            get { return miSL; }
            set { miSL = value; }
        }
        public int MiGia
        {
            get { return miGia; }
            set { miGia = value; }
        }
        public int MiTongtien
        {
            get { return miTongtien; }
            set { miTongtien = value; }
        }

        //Hàm tạo của lớp
        public ChiTietHoaDonNhapHang(int MaCTHD, int MaHDNhaphang, int MaNVL, int SL, int Gia, int Tongtien)
        {
            this.miMaCTHD       = MaCTHD;
            this.miMaHDNhaphang = MaHDNhaphang;
            this.miMaNVL        = MaNVL;
            this.miSL           = SL;
            this.miGia          = Gia;
            this.miTongtien     = Tongtien;
        }
    }
}
