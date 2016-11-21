using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ThucUong
    {
        //Thuộc tính lớp
        private int miMaTU; 
        private string msTenTU;
        private int miMaLoaiTU; 
        private int miThanhtien;
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaTU
        {
            get { return miMaTU; }
            set { miMaTU = value; }
        }
        public string MsTenTU
        {
            get { return msTenTU; }
            set { msTenTU = value; }
        }
        public int MiMaLoaiTU
        {
            get { return miMaLoaiTU; }
            set { miMaLoaiTU = value; }
        }
        public int MiThanhtien
        {
            get { return miThanhtien; }
            set { miThanhtien = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public ThucUong(int MaTU, string TenTU, int MaLoaiTU, int Thanhtien, int Status)
        {
            this.miMaTU      = MaTU;
            this.msTenTU     = TenTU;
            this.miMaLoaiTU  = MaLoaiTU;
            this.miThanhtien = Thanhtien;
            this.miStatus    = Status;
        }
    }
}
