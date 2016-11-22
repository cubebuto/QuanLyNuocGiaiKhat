using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class HoaDonNhapHangDAO: DBConnection
    {
        public bool ThemHoaDonNhapHang(HoaDonNhapHang hdnhobj)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC HOADONNHAPHANG_Ins @TONGTIEN, @NGAYNHAP, @MANVXACNHAN";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.VarChar).Value = hdnhobj.MiTongtien.ToString();
                cmd.Parameters.Add("@NGAYNHAP", System.Data.SqlDbType.VarChar).Value = hdnhobj.MdtNgaynhap.ToString();
                cmd.Parameters.Add("@MANVXACNHAN", System.Data.SqlDbType.VarChar).Value = hdnhobj.MiMaNVXacnhan.ToString();
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public bool CapNhatHoaDonNhapHang(HoaDonNhapHang hdnhobj)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC HOADONNHAPHANG_Upd @MAHDNHAPHANG, @CODEHD, @TONGTIEN, @NGAYNHAP, @MANVXACNHAN";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MAHDNHAPHANG", System.Data.SqlDbType.VarChar).Value = hdnhobj.MiMaHDNhaphang.ToString();
                cmd.Parameters.Add("@CODEHD", System.Data.SqlDbType.VarChar).Value = hdnhobj.MsCodeHD;
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.VarChar).Value = hdnhobj.MiTongtien.ToString();
                cmd.Parameters.Add("@NGAYNHAP", System.Data.SqlDbType.VarChar).Value = hdnhobj.MdtNgaynhap.ToString();
                cmd.Parameters.Add("@MANVXACNHAN", System.Data.SqlDbType.VarChar).Value = hdnhobj.MiMaNVXacnhan.ToString();
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public bool XoaHoaDonNhapHang(string sMAHDNHAPHANG)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC HOADONNHAPHANG_Del @MAHDNHAPHANG";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MAHDNHAPHANG", System.Data.SqlDbType.VarChar).Value = sMAHDNHAPHANG;
                cmd.ExecuteNonQuery();

                statement = "EXEC CTHOADONNHAPHANG_DelByMaHDNH @MAHDNHAPHANG";
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MAHDNHAPHANG", System.Data.SqlDbType.VarChar).Value = sMAHDNHAPHANG;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public bool PhucHoiHoaDonNhapHang(string sMAHDNHAPHANG)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC HOADONNHAPHANG_Restore @MAHDNHAPHANG";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MAHDNHAPHANG", System.Data.SqlDbType.VarChar).Value = sMAHDNHAPHANG;
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public DataTable DanhSachHoaDonNhapHangDaRemove()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC HOADONNHAPHANG_Lst0", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        public DataTable DanhSachHoaDonNhapHang()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC HOADONNHAPHANG_Lst1", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        public DataTable TimKiemHoaDonNhapHang(string sCODEHD, string sNGAYNHAP)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC HOADONNHAPHANG_Seach @CODEHD, @NGAYNHAP", conn);
                cmd.Parameters.Add("@CODEHD", System.Data.SqlDbType.NVarChar).Value = sCODEHD;
                cmd.Parameters.Add("@NGAYNHAP", System.Data.SqlDbType.VarChar).Value = sNGAYNHAP;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        public HoaDonNhapHang HoaDonNhapHangByMaHDNH(string sMAHDNHAPHANG)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC HOADONNHAPHANG_ById @MAHDNHAPHANG ", conn);
                cmd.Parameters.Add("@MAHDNHAPHANG", SqlDbType.VarChar).Value = sMAHDNHAPHANG;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                HoaDonNhapHang result = new HoaDonNhapHang(Int32.Parse(dt.Rows[0][0].ToString()),
                                                            dt.Rows[0][1].ToString(),
                                                            Int32.Parse(dt.Rows[0][2].ToString()),
                                                            Convert.ToDateTime(dt.Rows[0][3].ToString()),
                                                            Int32.Parse(dt.Rows[0][4].ToString()),
                                                            Int32.Parse(dt.Rows[0][5].ToString()));
                return result;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
    }
}
