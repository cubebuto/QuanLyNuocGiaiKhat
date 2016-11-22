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
    public class ChiTietHoaDonNhapHangDAO: DBConnection
    {
        public bool ThemChiTietHoaDonNhapHang(ChiTietHoaDonNhapHang cthdnhobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTHOADONNHAPHANG_Ins @MAHDNHAPHANG, @MANVL, @SL, @GIA, @TONGTIEN";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MAHDNHAPHANG", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiMaHDNhaphang.ToString();
                cmd.Parameters.Add("@MANVL", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiMaNVL.ToString();
                cmd.Parameters.Add("@SL", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiSL.ToString();
                cmd.Parameters.Add("@GIA", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiGia.ToString();
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiTongtien.ToString();
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
        public bool CapNhatChiTietHoaDonNhapHang(ChiTietHoaDonNhapHang cthdnhobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTHOADONNHAPHANG_Upd @MACTHD, @MAHDNHAPHANG, @MANVL, @SL, @GIA, @TONGTIEN";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MACTHD", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiMaCTHD.ToString();
                cmd.Parameters.Add("@MAHDNHAPHANG", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiMaHDNhaphang.ToString();
                cmd.Parameters.Add("@MANVL", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiMaNVL.ToString();
                cmd.Parameters.Add("@SL", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiSL.ToString();
                cmd.Parameters.Add("@GIA", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiGia.ToString();
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.VarChar).Value = cthdnhobj.MiTongtien.ToString();
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
        public bool XoaChiTietHoaDonNhapHang(string sMaCTHDNH)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTHOADONNHAPHANG_Del @MACTHD";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MACTHD", System.Data.SqlDbType.VarChar).Value = sMaCTHDNH;
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
        public DataTable ChiTietHoaDonNhapHangByMaHDNH(string sMaHDNH)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC CTHOADONNHAPHANG_ByHoaDonNhapHangId @MaHDNHAPHANG ", conn);
                cmd.Parameters.Add("@MaHDNHAPHANG", SqlDbType.VarChar).Value = sMaHDNH;
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
    }
}
