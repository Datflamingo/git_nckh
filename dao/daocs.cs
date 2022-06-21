using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NCKH_QLHH.dataprovider;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH.dao
{
    public class daocs
    {
        public dataprovider.DBConnection conn;
        
        public daocs()
        {
            conn = new dataprovider.DBConnection();
        }
        public void ThemHangHoa(String id, String Product, String Quanlity, String Ex)
        {
            const string sql = "insert into QLHH_main(id, Product, Quanlity, Ex) values(@id, @Product, @Quanlity, @Ex)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[0].Value = Convert.ToString(id);
            sqlParameters[1] = new SqlParameter("@Product", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Product);
            sqlParameters[2] = new SqlParameter("@Quanlity", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(Quanlity);
            sqlParameters[3] = new SqlParameter("@Ex", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(Ex);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void SuaHangHoa(String id, String Product, String Quanlity, String Ex)
        {
            const string sql = "update QLHH_main set Product = @Product, Quanlity = @Quanlity, Ex = @Ex where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Product", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Product);
            sqlParameters[1] = new SqlParameter("@Quanlity", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToString(Quanlity);
            sqlParameters[2] = new SqlParameter("@Ex", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Ex);
            sqlParameters[3] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[3].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public void XuatNhapHangHoa(String id, String Quanlity)
        {
            const string sql = "update QLHH_main set Quanlity = @Quanlity where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Quanlity", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(Quanlity);
            sqlParameters[1] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[1].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }


        public void XoaHangHoa(String id)
        {
            const string sql = "delete from QLHH_main where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[0].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }

        public DataTable CheckID(String id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                string sql = "select * from QLHH_main where id = ";
                sql = sql + id;

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            dt.Load(dataReader);
                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dt;
        }
    }
    public class HangHoaBUS
    {
        private daocs hhDAO;
        public HangHoaBUS()
        {
            hhDAO = new daocs();
        }
        public void ThemHangHoa(String id, String Product, String Quanlity, String Ex)
        {
            hhDAO.ThemHangHoa(id, Product, Quanlity, Ex);
        }

        public void SuaHangHoa(String id, String Product, String Quanlity, String Ex)
        {
            hhDAO.SuaHangHoa(id, Product, Quanlity, Ex);
        }
        
        
        public void XoaHangHoa(String id)
        {
            hhDAO.XoaHangHoa(id);
        }

        public void XuatNhapHangHoa(String id, String Quanlity)
        {
            hhDAO.XuatNhapHangHoa(id, Quanlity);
        }

        public DataTable CheckIDHH(String id)
        {
            return hhDAO.CheckID(id);
        }
    }
}
