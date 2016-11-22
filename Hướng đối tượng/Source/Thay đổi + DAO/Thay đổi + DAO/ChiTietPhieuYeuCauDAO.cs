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
    public class ChiTietPhieuYeuCauDAO: DBConnection
    {
        public bool ThemChiTietPhieuYeuCau(ChiTietPhieuYeuCau ctpycobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTPHIEUYEUCAU_Ins @MaPYC, @MaNL, @Soluong";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPYC", System.Data.SqlDbType.VarChar).Value = ctpycobj.MiMaPYC.ToString();
                cmd.Parameters.Add("@MaNL", System.Data.SqlDbType.VarChar).Value = ctpycobj.MiMaNL.ToString();
                cmd.Parameters.Add("@Soluong", System.Data.SqlDbType.VarChar).Value = ctpycobj.MiSoluong.ToString();
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
        public bool CapNhatChiTietPhieuYeuCau(ChiTietPhieuYeuCau ctpycobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTPHIEUYEUCAU_Upd @MaCTPYC, @MaPYC, @MaNL, @Soluong";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaCTPYC", System.Data.SqlDbType.VarChar).Value = ctpycobj.MiMaCTPYC.ToString();
                cmd.Parameters.Add("@MaPYC", System.Data.SqlDbType.VarChar).Value = ctpycobj.MiMaPYC.ToString();
                cmd.Parameters.Add("@MaNL", System.Data.SqlDbType.VarChar).Value = ctpycobj.MiMaNL.ToString();
                cmd.Parameters.Add("@Soluong", System.Data.SqlDbType.VarChar).Value = ctpycobj.MiSoluong.ToString();
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
        public bool XoaChiTietPhieuYeuCau(string sMaCTPYC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTPHIEUYEUCAU_Del @MaCTPYC";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaCTPYC", System.Data.SqlDbType.VarChar).Value = sMaCTPYC;
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
        public DataTable ChiTietPhieuYeuCauByMaPYC(string sMaCTPYC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC CTPHIEUYEUCAU_ByMaPYC @MaPYC ", conn);
                cmd.Parameters.Add("@MaPYC", SqlDbType.VarChar).Value = sMaCTPYC;
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
