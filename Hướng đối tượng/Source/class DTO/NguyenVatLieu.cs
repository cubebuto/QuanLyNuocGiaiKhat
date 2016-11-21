using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NguyenVatLieu
    {
        //Thuộc tính lớp
        private int miMaNL;     
        private string msTenNVL;      
        private int miSoluong;     
        private int miGia;       
        private string msTinhtrang; 
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaNL
        {
            get { return miMaNL; }
            set { miMaNL = value; }
        }
        public string MsTenNVL
        {
            get { return msTenNVL; }
            set { msTenNVL = value; }
        }
        public int MiSoluong
        {
            get { return miSoluong; }
            set { miSoluong = value; }
        }
        public int MiGia
        {
            get { return miGia; }
            set { miGia = value; }
        }
        public string MsTinhtrang
        {
            get { return msTinhtrang; }
            set { msTinhtrang = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public NguyenVatLieu(int MaNL, string TenNVL, int Soluong, 
                             int Gia, string Tinhtrang, int Status)
        {
            this.miMaNL         = MaNL;
            this.msTenNVL       = TenNVL;
            this.miSoluong      = Soluong;
            this.miGia          = Gia;
            this.msTinhtrang    = Tinhtrang;
            this.miStatus       = Status;
        }
    }
}
