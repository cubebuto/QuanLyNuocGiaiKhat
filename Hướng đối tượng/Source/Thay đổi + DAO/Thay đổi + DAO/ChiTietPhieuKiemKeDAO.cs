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
    public class ChiTietPhieuKiemKeDAO: DBConnection
    {
        public bool ThemChiTietPhieuKiemKe(ChiTietPhieuKiemKe ctpkkobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTPHIEUKIEMKE_Ins @MaPKK, @MaNL, @Soluongtrongkho, @Soluongthucte, @Lydochenhlech";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPKK", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MiMaPKK.ToString();
                cmd.Parameters.Add("@MaNL", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MiMaNL.ToString();
                cmd.Parameters.Add("@Soluongtrongkho", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MiSoluongtrongkho.ToString();
                cmd.Parameters.Add("@Soluongthucte", System.Data.SqlDbType.NVarChar).Value = ctpkkobj.MiSoluongthucte.ToString();
                cmd.Parameters.Add("@Lydochenhlech", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MsLydochenhlech;
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
        public bool CapNhatChiTietPhieuKiemKe(ChiTietPhieuKiemKe ctpkkobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTPHIEUKIEMKE_Upd @MaCTPKK, @MaPKK, @MaNL, @Soluongtrongkho, @Soluongthucte, @Lydochenhlech";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaCTPKK", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MiMaCTPKK.ToString();
                cmd.Parameters.Add("@MaPKK", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MiMaPKK.ToString();
                cmd.Parameters.Add("@MaNL", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MiMaNL.ToString();
                cmd.Parameters.Add("@Soluongtrongkho", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MiSoluongtrongkho.ToString();
                cmd.Parameters.Add("@Soluongthucte", System.Data.SqlDbType.NVarChar).Value = ctpkkobj.MiSoluongthucte.ToString();
                cmd.Parameters.Add("@Lydochenhlech", System.Data.SqlDbType.VarChar).Value = ctpkkobj.MsLydochenhlech;
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
        public bool XoaChiTietPhieuKiemKe(string sMaCTPKK)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC CTPHIEUKIEMKE_Del @MaCTPKK";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaCTPKK", System.Data.SqlDbType.VarChar).Value = sMaCTPKK;
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
        public DataTable ChiTietPhieuKiemKeByMaPKK(string sMaCTPKK)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC CTPHIEUKIEMKE_ByPhieuKiemKeId @MaPKK ", conn);
                cmd.Parameters.Add("@MaPKK", SqlDbType.VarChar).Value = sMaCTPKK;
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
