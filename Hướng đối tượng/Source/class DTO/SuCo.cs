using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SuCo
    {
        //Thuộc tính lớp
        private int miMaSC;
        private string msTenSC;
        private string msLydo;
        private DateTime mdtNgaytao;
        private string msTrangthai;
        private string msHuonggiaiquyet;   
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaSC
        {
            get { return miMaSC; }
            set { miMaSC = value; }
        }
        public string MsTenSC
        {
            get { return msTenSC; }
            set { msTenSC = value; }
        }
        public string MsLydo
        {
            get { return msLydo; }
            set { msLydo = value; }
        }
        public DateTime MdtNgaytao
        {
            get { return mdtNgaytao; }
            set { mdtNgaytao = value; }
        }
        public string MsTrangthai
        {
            get { return msTrangthai; }
            set { msTrangthai = value; }
        }
        public string MsHuonggiaiquyet
        {
            get { return msHuonggiaiquyet; }
            set { msHuonggiaiquyet = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public SuCo(int MaSC, string TenSC, string Lydo, DateTime Ngaytao, string Trangthai, string Huonggiaiquyet, int Status)
        {
            this.miMaSC             = MaSC;
            this.msTenSC            = TenSC;
            this.msLydo             = Lydo;
            this.mdtNgaytao         = Ngaytao;
            this.msTrangthai        = Trangthai;
            this.msHuonggiaiquyet   = Huonggiaiquyet;
            this.miStatus           = Status;
        }
    }
}
