using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhieuKiemKe
    {
        //Thuộc tính lớp
        private int miMaPKK; 
        private string msCodePKK;    
        private DateTime mdtNgaytao;    
        private int miMaNV; 
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaPKK
        {
            get { return miMaPKK; }
            set { miMaPKK = value; }
        }
        public string MsCodePKK
        {
            get { return msCodePKK; }
            set { msCodePKK = value; }
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
        public PhieuKiemKe(int MaPKK, string CodePKK, DateTime Ngaytao, int MaNV, int Status)
        {
            this.miMaPKK    = MaPKK;
            this.msCodePKK  = CodePKK;
            this.mdtNgaytao = Ngaytao;
            this.miMaNV     = MaNV;
            this.miStatus   = Status;
        }
    }
}
