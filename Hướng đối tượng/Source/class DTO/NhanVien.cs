using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien
    {
        //Thuộc tính lớp
        private int miMaNV;
        private string msTenNV;   
        private string msCodeNV;
        private string msChucVu;
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaNV
        {
            get { return miMaNV; }
            set { miMaNV = value; }
        }
        public string MsTenNV
        {
            get { return msTenNV; }
            set { msTenNV = value; }
        }
        public string MsCodeNV
        {
            get { return msCodeNV; }
            set { msCodeNV = value; }
        }
        public string MsChucVu
        {
            get { return msChucVu; }
            set { msChucVu = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public NhanVien(int MaNV, string TenNV, string CodeNV, string ChucVu, int Status)
        {
            this.miMaNV     = MaNV;
            this.msTenNV    = TenNV;
            this.msCodeNV   = CodeNV;
            this.msChucVu   = ChucVu;
            this.miStatus   = Status;
        }
    }
}
