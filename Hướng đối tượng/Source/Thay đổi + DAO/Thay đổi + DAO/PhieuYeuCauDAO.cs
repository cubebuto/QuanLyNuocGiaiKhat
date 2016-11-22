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
    public class PhieuYeuCauDAO: DBConnection
    {
        public bool ThemPhieuYeuCau(PhieuYeuCau pycobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUYEUCAU_Ins @Ngaytao, @MaNV";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.VarChar).Value = pycobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@MaNV", System.Data.SqlDbType.VarChar).Value = pycobj.MiMaNV.ToString();
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
        public bool CapNhatPhieuYeuCau(PhieuYeuCau pycobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUYEUCAU_Upd @MaPYC, @Ngaytao, @MaNV";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPYC", System.Data.SqlDbType.VarChar).Value = pycobj.MiMaPYC.ToString();
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.VarChar).Value = pycobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@MaNV", System.Data.SqlDbType.VarChar).Value = pycobj.MiMaNV.ToString();
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
        public bool XoaPhieuYeuCau(string sMaPYC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUYEUCAU_Del @MaPYC";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaSC", System.Data.SqlDbType.VarChar).Value = sMaPYC;
                cmd.ExecuteNonQuery();

                statement = "EXEC CTPHIEUYEUCAU_DelByMaPYC @MaPYC";
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaSC", System.Data.SqlDbType.VarChar).Value = sMaPYC;
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
        public bool PhucHoiSuCo(string sMaPYC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUYEUCAU_Restore @MaPYC";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPYC", System.Data.SqlDbType.VarChar).Value = sMaPYC;
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
        public DataTable DanhSachPhieuYeuCauDaRemove()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUYEUCAU_Lst0", conn);
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
        public DataTable DanhSachPhieuYeuCau()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUYEUCAU_Lst1", conn);
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
        public PhieuYeuCau PhieuYeuCauByMaPYC(string sMaPYC)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUYEUCAU_ById @MaPYC ", conn);
                cmd.Parameters.Add("@MaPYC", SqlDbType.VarChar).Value = sMaPYC;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                PhieuYeuCau result = new PhieuYeuCau(Int32.Parse(dt.Rows[0][0].ToString()),
                                                        Convert.ToDateTime(dt.Rows[0][1].ToString()),
                                                        Int32.Parse(dt.Rows[0][2].ToString()),
                                                        Int32.Parse(dt.Rows[0][3].ToString()));
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
