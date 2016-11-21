using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDonNhapHang
    {
        //Thuộc tính lớp
        private int miMaHDNhaphang;
        private string msCodeHD;  
        private int miTongtien;     
        private DateTime mdtNgaynhap;  
        private int miMaNVXacnhan;  
        private int miStatus;   

        //Phương thức get set của lớp
        public int MiMaHDNhaphang
        {
            get { return miMaHDNhaphang; }
            set { miMaHDNhaphang = value; }
        }
        public string MsCodeHD
        {
            get { return msCodeHD; }
            set { msCodeHD = value; }
        }
        public int MiTongtien
        {
            get { return miTongtien; }
            set { miTongtien = value; }
        }
        public DateTime MdtNgaynhap
        {
            get { return mdtNgaynhap; }
            set { mdtNgaynhap = value; }
        }
        public int MiMaNVXacnhan
        {
            get { return miMaNVXacnhan; }
            set { miMaNVXacnhan = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public HoaDonNhapHang(int MaHDNhaphang, string CodeHD, int Tongtien, DateTime Ngaynhap, int MaNVXacnhan, int Status)
        {
            this.miMaHDNhaphang = MaHDNhaphang;
            this.msCodeHD       = CodeHD;
            this.miTongtien     = Tongtien;
            this.mdtNgaynhap    = Ngaynhap;
            this.miMaNVXacnhan  = MaNVXacnhan;
            this.miStatus       = Status;
        }
    }
}
