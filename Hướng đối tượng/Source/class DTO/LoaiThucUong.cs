using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LoaiThucUong
    {
        //Thuộc tính lớp
        private int miMaLoaiTU;
        private string msTenTU;    
        private int miStatus;

        //Phương thức get set của lớp
        public int MiMaLoaiTU
        {
            get { return miMaLoaiTU; }
            set { miMaLoaiTU = value; }
        }
        public string MsTenTU
        {
            get { return msTenTU; }
            set { msTenTU = value; }
        }
        public int MiStatus
        {
            get { return miStatus; }
            set { miStatus = value; }
        }

        //Hàm tạo của lớp
        public LoaiThucUong(int MaLoaiTU, string TenTU, int Status)
        {
            this.miMaLoaiTU = MaLoaiTU;
            this.msTenTU = TenTU;
            this.miStatus = Status;
        }
    }
}
