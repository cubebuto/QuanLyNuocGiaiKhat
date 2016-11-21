using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhieuYeuCau
    {
        //Thuộc tính lớp
        private int miMaPYC;    
        private DateTime mdtNgaytao; 
        private int miMaNV;    
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaPYC
        {
            get { return miMaPYC; }
            set { miMaPYC = value; }
        }
        public DateTime MdtNgaytao
        {
            get { return mdtNgaytao; }
            set { mdtNgaytao = value; }
        }
        public int MiMaNV
        {
            get { return miMaNV; }
            set { miMaNV = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public PhieuYeuCau(int MaPYC, DateTime Ngaytao, int MaNV, int Status)
        {
            this.miMaPYC    = MaPYC;
            this.mdtNgaytao = Ngaytao;
            this.miMaNV     = MaNV;
            this.miStatus   = Status;
        }
    }
}
