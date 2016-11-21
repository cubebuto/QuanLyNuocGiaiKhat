using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChiTietPhieuKiemKe
    {
        //Thuộc tính lớp
        private int miMaCTPKK;
        private int miMaPKK;
        private int miMaNL;
        private int miSoluongtrongkho;
        private int miSoluongthucte;
        private string msLydochenhlech;
        private int miStatus;
       
        //Phương thức get set của lớp
        public int MiMaCTPKK
        {
            get { return miMaCTPKK; }
            set { miMaCTPKK = value; }
        }
        public int MiMaPKK
        {
            get { return miMaPKK; }
            set { miMaPKK = value; }
        }
        public int MiMaNL
        {
            get { return miMaNL; }
            set { miMaNL = value; }
        }
        public int MiSoluongtrongkho
        {
            get { return miSoluongtrongkho; }
            set { miSoluongtrongkho = value; }
        }
        public int MiSoluongthucte
        {
            get { return miSoluongthucte; }
            set { miSoluongthucte = value; }
        }
        public string MsLydochenhlech
        {
            get { return msLydochenhlech; }
            set { msLydochenhlech = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public ChiTietPhieuKiemKe(int MaCTPKK, int MaPKK, int MaNL, int Soluongtrongkho, int Soluongthucte, string Lydochenhlech, int Status)
        {
            this.miMaCTPKK          = MaCTPKK;
            this.miMaPKK            = MaPKK;
            this.miMaNL             = MaNL;
            this.miSoluongtrongkho  = Soluongtrongkho;
            this.miSoluongthucte    = Soluongthucte;
            this.msLydochenhlech    = Lydochenhlech;
            this.miStatus           = Status;
        }
    }
}
