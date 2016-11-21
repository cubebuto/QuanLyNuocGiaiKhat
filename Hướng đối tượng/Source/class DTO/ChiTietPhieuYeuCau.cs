using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChiTietPhieuYeuCau
    {
         //Thuộc tính lớp
        private int miMaCTPYC;   
        private int miMaPYC;      
        private int miMaNL;    
        private int miSoluong;

        //Phương thức get set của lớp
        public int MiMaCTPYC
        {
            get { return miMaCTPYC; }
            set { miMaCTPYC = value; }
        }
        public int MiMaPYC
        {
            get { return miMaPYC; }
            set { miMaPYC = value; }
        }
        public int MiMaNL
        {
            get { return miMaNL; }
            set { miMaNL = value; }
        }
        public int MiSoluong
        {
            get { return miSoluong; }
            set { miSoluong = value; }
        }

        //Hàm tạo của lớp
        public ChiTietPhieuYeuCau(int MaCTPYC, int MaPYC, int MaNL, int Soluong)
        {
            this.miMaCTPYC  = MaCTPYC;
            this.miMaPYC    = MaPYC;
            this.miMaNL     = MaNL;
            this.miSoluong  = Soluong;
        }
    }
}
