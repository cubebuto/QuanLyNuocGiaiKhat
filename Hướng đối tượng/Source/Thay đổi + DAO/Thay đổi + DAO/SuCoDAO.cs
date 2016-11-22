using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DAL
{
    public class SuCoDAO: DBConnection
    {
        public bool ThemSuCo(SuCo scobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC SUCO_Ins @TenSC, @Lydo, @Ngaytao, @Trangthai, @Huonggiaiquyet";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@TenSC", System.Data.SqlDbType.NVarChar).Value = scobj.MsTenSC;
                cmd.Parameters.Add("@Lydo", System.Data.SqlDbType.NVarChar).Value = scobj.MsLydo;
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.VarChar).Value = scobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@Trangthai", System.Data.SqlDbType.VarChar).Value = scobj.MsTrangthai;
                cmd.Parameters.Add("@Huonggiaiquyet", System.Data.SqlDbType.NVarChar).Value = scobj.MsHuonggiaiquyet;
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
        public bool CapNhatSuCo(SuCo scobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC SUCO_Upd @MaSC, @TenSC, @Lydo, @Ngaytao, @Trangthai, @Huonggiaiquyet";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@TenSC", System.Data.SqlDbType.VarChar).Value = scobj.MiMaSC;
                cmd.Parameters.Add("@TenSC", System.Data.SqlDbType.NVarChar).Value = scobj.MsTenSC;
                cmd.Parameters.Add("@Lydo", System.Data.SqlDbType.NVarChar).Value = scobj.MsLydo;
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.VarChar).Value = scobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@Trangthai", System.Data.SqlDbType.VarChar).Value = scobj.MsTrangthai;
                cmd.Parameters.Add("@Huonggiaiquyet", System.Data.SqlDbType.NVarChar).Value = scobj.MsHuonggiaiquyet;
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
        public bool XoaSuCo(string sMaSC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC SUCO_Del @MaSC";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaSC", System.Data.SqlDbType.VarChar).Value = sMaSC;
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
        public bool PhucHoiSuCo(string sMaSC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC SUCO_Restore @MaSC";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaSC", System.Data.SqlDbType.VarChar).Value = sMaSC;
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
        public DataTable DanhSachSuCoDaRemove()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC SUCO_Lst0", conn);
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
        public DataTable DanhSachSuCo()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC SUCO_Lst1", conn);
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
        public DataTable TimKiemSuCo(string sTenSC)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC SUCO_Seach @TenSC", conn);
                cmd.Parameters.Add("@TenSC", System.Data.SqlDbType.VarChar).Value = sTenSC;
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
        public SuCo SuCoByMaSuCo(string sMaSC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC SUCO_ById @sMaSC ", conn);
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = sMaSC;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                SuCo result = new SuCo(Int32.Parse(dt.Rows[0][0].ToString()),
                                          dt.Rows[0][1].ToString(),
                                          dt.Rows[0][2].ToString(),
                                          Convert.ToDateTime(dt.Rows[0][3].ToString()),
                                          dt.Rows[0][4].ToString(),
                                          dt.Rows[0][5].ToString(),
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
