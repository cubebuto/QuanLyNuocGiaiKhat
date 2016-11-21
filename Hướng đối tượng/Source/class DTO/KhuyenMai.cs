using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KhuyenMai
    {
        //Thuộc tính lớp
        private int miMavoucher;    
        private string msCodevoucher;   
        private string msTenvoucher;  
        private int miGiagiam;     
        private DateTime mdtNgaytao;    
        private DateTime mdtNgaybatdau;   
        private DateTime mdtNgayketthuc;        
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMavoucher
        {
            get { return miMavoucher; }
            set { miMavoucher = value; }
        }
        public string MsCodevoucher
        {
            get { return msCodevoucher; }
            set { msCodevoucher = value; }
        }
        public string MsTenvoucher
        {
            get { return msTenvoucher; }
            set { msTenvoucher = value; }
        }
        public int MiGiagiam
        {
            get { return miGiagiam; }
            set { miGiagiam = value; }
        }
        public DateTime MdtNgaytao
        {
            get { return mdtNgaytao; }
            set { mdtNgaytao = value; }
        }
        public DateTime MdtNgaybatdau
        {
            get { return mdtNgaybatdau; }
            set { mdtNgaybatdau = value; }
        }
        public DateTime MdtNgayketthuc
        {
            get { return mdtNgayketthuc; }
            set { mdtNgayketthuc = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public KhuyenMai(int Mavoucher, string Codevoucher, string Tenvoucher, int Giagiam, DateTime Ngaytao, DateTime Ngaybatdau, DateTime Ngayketthuc, int Status)
        {
            this.miMavoucher    = Mavoucher;
            this.msCodevoucher  = Codevoucher;
            this.msTenvoucher   = Tenvoucher;
            this.miGiagiam      = Giagiam;
            this.mdtNgaytao     = Ngaytao;
            this.mdtNgaybatdau  = Ngaybatdau;
            this.mdtNgayketthuc = Ngayketthuc;
            this.miStatus       = Status;
        }
    }
}
