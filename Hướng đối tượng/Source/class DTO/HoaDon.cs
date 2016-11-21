using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDon
    {
        //Thuộc tính lớp
        private int miMaHD;   
        private string msCodeHD;     
        private int miTongtienbd;  
        private int miGiagiam; 
        private int miThanhtien;
        private int miMaNV;  
        private DateTime mdtNgaytao;      
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaHD
        {
            get { return miMaHD; }
            set { miMaHD = value; }
        }
        public string MsCodeHD
        {
            get { return msCodeHD; }
            set { msCodeHD = value; }
        }
        public int MiTongtienbd
        {
            get { return miTongtienbd; }
            set { miTongtienbd = value; }
        }
        public int MiGiagiam
        {
            get { return miGiagiam; }
            set { miGiagiam = value; }
        }
        public int MiThanhtien
        {
            get { return miThanhtien; }
            set { miThanhtien = value; }
        }
        public int MiMaNV
        {
            get { return miMaNV; }
            set { miMaNV = value; }
        }
        public DateTime MdtNgaytao
        {
            get { return mdtNgaytao; }
            set { mdtNgaytao = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public HoaDon(int MaHD, string CodeHD, int Tongtienbd, int Giagiam, int Thanhtien, int MaNV, DateTime Ngaytao, int Status)
        {
            this.miMaHD       = MaHD;
            this.msCodeHD     = CodeHD;
            this.miTongtienbd = Tongtienbd;
            this.miGiagiam    = Giagiam;
            this.miThanhtien  = Thanhtien;
            this.miMaNV       = MaNV;
            this.mdtNgaytao   = Ngaytao;
            this.miStatus     = Status;
        }
    }
}
