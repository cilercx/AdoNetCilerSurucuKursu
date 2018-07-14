using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCore.DATA.ADONET
{
    public class BaseConnectionHelper: IDisposable
    {

        public BaseConnectionHelper(string connectionStringName)
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }
        public string ConnectionString { get; set; }

        public void Dispose()
        {
            ConnectionString = null;
            GC.SuppressFinalize(this);
        }

        public int ExecuteCommand(string command, SqlParameter[] parametres = null, CommandType type = CommandType.Text)//SqlParameter[] parametres = null(parametres dizisi boşsa..)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                       
                        if (parametres != null)//parametre boş değilse..
                        {
                            cmd.Parameters.AddRange(parametres);
                        }
                        cmd.CommandType = type;
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                        //ExecuteNonQuery()=update,delete,Insert dönüş tipi int..
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public SqlDataReader GetData(string query,SqlParameter[] parametres=null, CommandType type = CommandType.Text)// using blokları kullanılmaz cünkü bağlantı acık kalması gerekiyor..SqlParameter[] ile kullanıcı ad soyad ve sifre parametreleri istenir..
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = type;
                if (parametres!=null)
                {
                    cmd.Parameters.AddRange(parametres);
                }
                con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //ExecuteReader= select ve tablo getirir.
            }
            catch (Exception)
            {

                throw;
            }
            return reader;
        }
    }
}
