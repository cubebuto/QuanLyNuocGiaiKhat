using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChiTietHoaDon
    {
        //Thuộc tính lớp
        private int miMaCTHD;      
        private int miMaHD;     
        private int miMaTU;    
        private int miGiatien;   
        private int miSoluong;    
        private int miThanhtien;

        //Phương thức get set của lớp
        public int MiMaCTHD
        {
            get { return miMaCTHD; }
            set { miMaCTHD = value; }
        }
        public int MiMaHD
        {
            get { return miMaHD; }
            set { miMaHD = value; }
        }
        public int MiMaTU
        {
            get { return miMaTU; }
            set { miMaTU = value; }
        }
        public int MiGiatien
        {
            get { return miGiatien; }
            set { miGiatien = value; }
        }
        public int MiSoluong
        {
            get { return miSoluong; }
            set { miSoluong = value; }
        }
        public int MiThanhtien
        {
            get { return miThanhtien; }
            set { miThanhtien = value; }
        }

        //Hàm tạo của lớp
        public ChiTietHoaDon(int MaCTHD, int MaHD, int MaTU, int Giatien, int Soluong, int Thanhtien)
        {
            this.miMaCTHD    = MaCTHD;
            this.miMaHD      = MaHD;
            this.miMaTU      = MaTU;
            this.miGiatien   = Giatien;
            this.miSoluong   = Soluong;
            this.miThanhtien = Thanhtien;
        }
    }
}
