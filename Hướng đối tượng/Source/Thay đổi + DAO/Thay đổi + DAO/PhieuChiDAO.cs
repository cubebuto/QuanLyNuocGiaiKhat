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
    public class PhieuChiDAO: DBConnection
    {
        public bool ThemPhieuChi(PhieuChi pcobj)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUCHI_Ins @Ngaytao, @Lydo, @Sotien, @MaNV";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.VarChar).Value = pcobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@Lydo", System.Data.SqlDbType.NVarChar).Value = pcobj.MsLydo;
                cmd.Parameters.Add("@Sotien", System.Data.SqlDbType.VarChar).Value = pcobj.MiSotien.ToString();
                cmd.Parameters.Add("@MaNV", System.Data.SqlDbType.VarChar).Value = pcobj.MiMaNV.ToString();
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
        public bool CapNhatPhieuChi(PhieuChi pcobj)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUCHI_Upd @MaPC, @CodePC, @Ngaytao, @Lydo, @Sotien, @MaNV";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPC", System.Data.SqlDbType.VarChar).Value = pcobj.MiMaPC.ToString();
                cmd.Parameters.Add("@CodePC", System.Data.SqlDbType.VarChar).Value = pcobj.MsCodePC;
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.VarChar).Value = pcobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@Lydo", System.Data.SqlDbType.NVarChar).Value = pcobj.MsLydo;
                cmd.Parameters.Add("@Sotien", System.Data.SqlDbType.VarChar).Value = pcobj.MiSotien.ToString();
                cmd.Parameters.Add("@MaNV", System.Data.SqlDbType.VarChar).Value = pcobj.MiMaNV.ToString();
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
        public bool XoaPhieuChi(string sMaPC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUCHI_Del @MaPC";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPC", System.Data.SqlDbType.VarChar).Value = sMaPC;
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
        public bool PhucHoiPhieuChi(string sMaPC)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUCHI_Restore @MaPC";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPC", System.Data.SqlDbType.VarChar).Value = sMaPC;
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
        public DataTable DanhSachPhieuChiDaRemove()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUCHI_Lst0", conn);
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
        public DataTable DanhSachPhieuChi()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUCHI_Lst1", conn);
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
        public DataTable TimKiemPhieuChi(string sLydo)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUCHI_Seach @Lydo", conn);
                cmd.Parameters.Add("@Lydo", System.Data.SqlDbType.VarChar).Value = sLydo;
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
        public PhieuChi PhieuChiByMaPhieuChi(string sMaPC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUCHI_ById @MaPC ", conn);
                cmd.Parameters.Add("@MaPC", SqlDbType.VarChar).Value = sMaPC;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                PhieuChi result = new PhieuChi(Int32.Parse(dt.Rows[0][0].ToString()),
                                               dt.Rows[0][1].ToString(),
                                               Convert.ToDateTime(dt.Rows[0][2].ToString()),
                                               dt.Rows[0][3].ToString(),
                                               Int32.Parse(dt.Rows[0][4].ToString()),
                                               Int32.Parse(dt.Rows[0][5].ToString()),
                                               Int32.Parse(dt.Rows[0][6].ToString()));
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
