using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ThanhVien
    {
        //Thuộc tính lớp
        private int miMaTV;   
        private string msTenTV;  
        private string msGioitinh;      
        private DateTime mdtNgaysinh;       
        private string msEmail;   
        private string msSDT;     
        private int miTongtientichluy;   
        private int miDiemtichluy;     
        private string msDiachi;  
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaTV
        {
            get { return miMaTV; }
            set { miMaTV = value; }
        }
        public string MsTenTV
        {
            get { return msTenTV; }
            set { msTenTV = value; }
        }
        public string MsGioitinh
        {
            get { return msGioitinh; }
            set { msGioitinh = value; }
        }
        public DateTime MdtNgaysinh
        {
            get { return mdtNgaysinh; }
            set { mdtNgaysinh = value; }
        }
        public string MsEmail
        {
            get { return msEmail; }
            set { msEmail = value; }
        }
        public string MsSDT
        {
            get { return msSDT; }
            set { msSDT = value; }
        }
        public int MiTongtientichluy
        {
            get { return miTongtientichluy; }
            set { miTongtientichluy = value; }
        }
        public int MiDiemtichluy
        {
            get { return miDiemtichluy; }
            set { miDiemtichluy = value; }
        }
        public string MsDiachi
        {
            get { return msDiachi; }
            set { msDiachi = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public ThanhVien(int MaTV, string TenTV, string Gioitinh, DateTime Ngaysinh, string Email, 
                         string SDT, int Tongtientichluy, int Diemtichluy, string Diachi, int Status)
        {
            this.miMaTV             = MaTV;
            this.msTenTV            = TenTV;
            this.msGioitinh         = Gioitinh;
            this.mdtNgaysinh        = Ngaysinh;
            this.msEmail            = Email;
            this.msSDT              = SDT;
            this.miTongtientichluy  = Tongtientichluy;
            this.miDiemtichluy      = Diemtichluy;
            this.msDiachi           = Diachi;
            this.miStatus           = Status;
        }
    }
}
