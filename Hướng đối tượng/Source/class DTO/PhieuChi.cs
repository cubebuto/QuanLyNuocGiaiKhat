using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhieuChi
    {
        //Thuộc tính lớp
        private int miMaPC;    
        private string msCodePC;  
        private DateTime mdtNgaytao;   
        private string msLydo;      
        private int miSotien;     
        private int miMaNV;     
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaPC
        {
            get { return miMaPC; }
            set { miMaPC = value; }
        }
        public string MsCodePC
        {
            get { return msCodePC; }
            set { msCodePC = value; }
        }
        public DateTime MdtNgaytao
        {
            get { return mdtNgaytao; }
            set { mdtNgaytao = value; }
        }
        public string MsLydo
        {
            get { return msLydo; }
            set { msLydo = value; }
        }
        public int MiSotien
        {
            get { return miSotien; }
            set { miSotien = value; }
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
        public PhieuChi(int MaPC, string CodePC, DateTime Ngaytao, string Lydo, int Sotien, int MaNV, int Status)
        {
            this.miMaPC     = MaPC;
            this.msCodePC   = CodePC;
            this.mdtNgaytao = Ngaytao;
            this.msLydo     = Lydo;
            this.miSotien   = Sotien;
            this.miMaNV     = MaNV;
            this.miStatus   = Status;
        }
    }
}
