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
    public class PhieuKiemKeDAO: DBConnection
    {
        public bool ThemPhieuKiemKe(PhieuKiemKe pkkobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUKIEMKE_Ins @Ngaytao, @MaNV";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.NVarChar).Value = pkkobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@MaNV", System.Data.SqlDbType.NVarChar).Value = pkkobj.MiMaNV.ToString();
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
        public bool CapNhatPhieuKiemKe(PhieuKiemKe pkkobj)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUKIEMKE_Upd @MaPKK, @CodePKK, @Ngaytao, @MaNV";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPKK", System.Data.SqlDbType.VarChar).Value = pkkobj.MiMaPKK.ToString();
                cmd.Parameters.Add("@CodePKK", System.Data.SqlDbType.NVarChar).Value = pkkobj.MsCodePKK;
                cmd.Parameters.Add("@Ngaytao", System.Data.SqlDbType.NVarChar).Value = pkkobj.MdtNgaytao.ToString();
                cmd.Parameters.Add("@MaNV", System.Data.SqlDbType.VarChar).Value = pkkobj.MiMaNV.ToString();
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
        public bool XoaPhieuKiemKe(string sMaPKK)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC PHIEUKIEMKE_Del @MaPKK";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPKK", System.Data.SqlDbType.VarChar).Value = sMaPKK;
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
        public bool PhucHoiPhieuKiemKe(string sMaPKK)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string statement = "EXEC SUCO_Restore @MaPKK";
                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add("@MaPKK", System.Data.SqlDbType.VarChar).Value = sMaPKK;
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
        public DataTable DanhSachPhieuKiemKeDaRemove()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUKIEMKE_Lst0", conn);
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
        public DataTable DanhSachPhieuKiemKe()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC PHIEUKIEMKE_Lst1", conn);
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
        public PhieuKiemKe PhieuKiemKeByMaPKK(string sMaPKK)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC SUCO_ById @MaPKK ", conn);
                cmd.Parameters.Add("@MaPKK", SqlDbType.VarChar).Value = sMaPKK;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                PhieuKiemKe result = new PhieuKiemKe(Int32.Parse(dt.Rows[0][0].ToString()),
                                                     dt.Rows[0][1].ToString(),
                                                     Convert.ToDateTime(dt.Rows[0][2].ToString()),
                                                     Int32.Parse(dt.Rows[0][3].ToString()),
                                                     Int32.Parse(dt.Rows[0][4].ToString()));
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
